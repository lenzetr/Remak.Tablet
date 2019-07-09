using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Lenze.Desktop.Database
{
    public class SQLLite
    {
        #region Properties

        public string AppName { get; set; } = Process.GetCurrentProcess().ProcessName;
        private string MainDir { get; } = AppDomain.CurrentDomain.BaseDirectory;
        public string DatabaseName => Path.Combine(Global.DatabaseDirectory, $"{AppName}.db3");
        public string DataSource => $"Data Source={DatabaseName};Version=3;";

        private SQLiteCommand _command;
        private readonly SQLiteConnection _connection;

        public BindingSource bindingSource = new BindingSource();
        public SQLiteDataAdapter dataAdapter;

        public bool firstOpenDb;
        #endregion

        #region Initialize

        public SQLLite(string dbName = "")
        {
            // var db = string.IsNullOrEmpty(dbName) ? DatabaseName : Path.Combine(MainDir, dbName);

            var db = string.IsNullOrEmpty(dbName) ? DatabaseName : Path.Combine(MainDir, dbName);


            if (!File.Exists(db))
            {
                SQLiteConnection.CreateFile(db);

                firstOpenDb = true;
            }

            try
            {
                _connection = new SQLiteConnection($"Data Source={db};Version=3;");
                OpenConnection();
            }
            catch (SQLiteException e)
            {
                switch (e.ErrorCode)
                {
                    case 0:
                        throw new Exception("Cannot connect to server. Contact administrator !");

                    case 1045:
                        throw new Exception(
                            "Invalid username/password. Please check your connection string and try again !");
                }
            }
            finally
            {
                if (firstOpenDb) CreateDefaultTables();
            }
        }

        public SQLiteParameterCollection Parameters
        {
            get => _command.Parameters;
            set
            {
                foreach (SQLiteParameter param in value)
                    _command.Parameters.Add(param);
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = new SQLiteConnection(DataSource))
                {
                    conn.Open();
                    conn.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
        #endregion

        private void CreateDefaultTables()
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                sh.DropTable("Settings");

                var tbSettings = new SQLiteTable("Settings");
                tbSettings.Columns.Add(new SQLiteColumn("id", true));
                tbSettings.Columns.Add(new SQLiteColumn("name"));
                tbSettings.Columns.Add(new SQLiteColumn("value"));
                tbSettings.Columns.Add(new SQLiteColumn("status", ColType.Integer));
                sh.CreateTable(tbSettings);


                sh.DropTable("ErrorList");

                var tbErrorList = new SQLiteTable("ErrorList");
                tbErrorList.Columns.Add(new SQLiteColumn("id", true));
                tbErrorList.Columns.Add(new SQLiteColumn("Module"));
                tbErrorList.Columns.Add(new SQLiteColumn("Name"));
                tbErrorList.Columns.Add(new SQLiteColumn("Message"));
                tbErrorList.Columns.Add(new SQLiteColumn("Exception"));
                tbErrorList.Columns.Add(new SQLiteColumn("Date", ColType.DateTime));
                sh.CreateTable(tbErrorList);
            }

            firstOpenDb = false;
        }

        #region SQL Functions

        public void Query(string sql)
        {
            using (var command = new SQLiteCommand(sql, _connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SQLiteDataAdapter(selectCommand, _connection);
                var commandBuilder = new SQLiteCommandBuilder(dataAdapter);

                var table = new DataTable {Locale = CultureInfo.InvariantCulture};
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
                table.AcceptChanges();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool TruncateTable(string tableName)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                try
                {
                    var sh = new SQLiteHelper(cmd);
                    sh.Execute("DELETE FROM @TableName;UPDATE sqlite_sequence SET seq = 0 WHERE name = '@TableName';",
                        new[] {new SQLiteParameter("@TableName", tableName)});
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region ErrorLog
        public long InsertErrorLog(ErrorList items)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                var dic = new Dictionary<string, object>
                {
                    ["Module"] = items.Module,
                    ["Name"] = items.Name,
                    ["Message"] = items.Message,
                    ["Exception"] = items.Exception,
                    ["Date"] = items.Date
                };

                sh.Insert("ErrorList", dic);

                return sh.LastInsertRowId();
            }
        }

        #endregion

        #region Setting

        public long InsertSetting(string nameVal, string valueVal)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                var dic = new Dictionary<string, object>
                {
                    ["name"] = nameVal,
                    ["value"] = valueVal
                };

                var settingCheck = GetSettingsId(nameVal);
                if (settingCheck > 0)
                    sh.Update("Settings", dic, "id", settingCheck);
                else
                    sh.Insert("Settings", dic);

                return sh.LastInsertRowId();
            }
        }

        public string GetSettingsValue(string name)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                var result = sh.ExecuteScalar<string>("SELECT value FROM Settings WHERE name = @name",
                    new[] {new SQLiteParameter("@name", name)});


                return result;
            }
        }

        public long GetSettingsId(string name)
        {
            try
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.Connection = _connection;

                    var sh = new SQLiteHelper(cmd);

                    var result = sh.ExecuteScalar<long>("SELECT id FROM Settings WHERE name = @name",
                        new[] {new SQLiteParameter("@name", name)});

                    return result;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #region SynchronousMotorItems

        /* public void Create(SynchronousMotorItems items)
        {
            SQLiteCommand insertSQL =
                new SQLiteCommand("INSERT INTO SynchronousMotors (name, LabelText, DataId, Type) VALUES (?,?,?,?)",
                    _connection);

            insertSQL.Parameters.Add(new SQLiteParameter(DbType.String, "@name") { Value = items.Name });
            insertSQL.Parameters.Add(new SQLiteParameter(DbType.String, "@LabelText") { Value = items.Description });
            insertSQL.Parameters.Add(new SQLiteParameter(DbType.String, "@DataId") { Value = items.Id });
            insertSQL.Parameters.Add(new SQLiteParameter(DbType.String, "@Type") { Value = items.Type });

            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        */
        /*public long Insert(SynchronousMotorItems items)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                var dic = new Dictionary<string, object>
                {
                    ["name"] = items.Name,
                    ["description"] = items.Description,
                    ["dataId"] = items.Id
                };

                sh.Insert("SynchronousMotors", dic);

                return sh.LastInsertRowId();
            }
        }*/

        /*public List<SynchronousMotorItems> SelectSynchronousMotor()
        {
            var items = new List<SynchronousMotorItems>();
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);
                IEnumerable<SynchronousMotorDbItems> result = sh.Select("SELECT * FROM SynchronousMotors;").DataTableToList<SynchronousMotorDbItems>();
                items.AddRange(result.Select(itmRow => new SynchronousMotorItems() { Name = itmRow.Name, Description = itmRow.Description, Id = itmRow.dataId, DatabaseId = itmRow.id }));

                return items;
            }
        }*/

        public int DeleteSynchronousMotor(int id)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                try
                {
                    var sh = new SQLiteHelper(cmd);
                    sh.Execute("DELETE FROM SynchronousMotors WHERE id=@id", new[] {new SQLiteParameter("@id", id)});
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
        #endregion
    }
}
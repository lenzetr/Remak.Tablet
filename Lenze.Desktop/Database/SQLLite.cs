using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Lenze.Desktop.Database
{
    public class SQLLite
    {
        private SQLiteConnection _connection;
        public SQLiteDataAdapter dataAdapter;
        private SQLiteCommand _command;

        public string AppName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        private string MainDir { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        public string DatabaseName => Path.Combine(Global.DatabaseDirectory, $"{AppName}.db3");

        public bool firstOpenDb = false;

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
                if (firstOpenDb)
                {
                    CreateDefaultTables();
                }
            }
        }

        public string DataSource => $"Data Source={DatabaseName};Version=3;";

        public bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DataSource))
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
            }

            firstOpenDb = false;
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

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public void Query(string sql)
        {
            using (var command = new SQLiteCommand(sql, _connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public BindingSource bindingSource = new BindingSource();

        public void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SQLiteDataAdapter(selectCommand, _connection);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);

                DataTable table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
                table.AcceptChanges();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
        public bool TruncateTable(string tableName)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                try
                {
                    var sh = new SQLiteHelper(cmd);
                    sh.Execute("DELETE FROM @TableName;UPDATE sqlite_sequence SET seq = 0 WHERE name = '@TableName';", new SQLiteParameter[] { new SQLiteParameter("@TableName", tableName) });
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

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

        public long InsertSetting(string nameVal, string valueVal)
        {

            using (SQLiteCommand cmd = new SQLiteCommand())
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
                {
                    sh.Update("Settings", dic, "id", settingCheck);
                }
                else
                {
                    sh.Insert("Settings", dic);
                }

                return sh.LastInsertRowId();
            }
        }

        public string GetSettingsValue(string name)
        {
            using (var cmd = new SQLiteCommand())
            {
                cmd.Connection = _connection;

                var sh = new SQLiteHelper(cmd);

                var result = sh.ExecuteScalar<string>("SELECT value FROM Settings WHERE name = @name", new SQLiteParameter[] { new SQLiteParameter("@name", name) });


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

                    var result = sh.ExecuteScalar<long>("SELECT id FROM Settings WHERE name = @name", new SQLiteParameter[] { new SQLiteParameter("@name", name) });

                    return result;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

       /* public List<SynchronousMotorItems> SelectSynchronousMotor()
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
                    sh.Execute("DELETE FROM SynchronousMotors WHERE id=@id", new SQLiteParameter[] { new SQLiteParameter("@id", id) });
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
    }

}

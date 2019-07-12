using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lenze.Desktop.Helpers;
using Lenze.Desktop.Model;
using Lenze.Desktop.Services;

namespace Lenze.Desktop.View
{
    public partial class ErrorListForm : Form
    {
        public ErrorListForm()
        {
            InitializeComponent();
        }

        private void ErrorListForm_Load(object sender, EventArgs e)
        {
            LoadList();

            btnReConnection.Visible = Client.ConnectionStatus == false;
        }

        private void LoadList()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }

            dataGridView1.Refresh();

            try
            {
                dataGridView1.DataSource = Global.ErrorList;

                dataGridView1.Columns["Module"].Width = 100;
                dataGridView1.Columns["Name"].Width = 120;
                dataGridView1.Columns["Message"].Width = 430;
                dataGridView1.Columns["Exception"].Width = 290;

                dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView1.ColumnHeadersHeight = 30;
                dataGridView1.CellPainting += DataGridView1_CellPainting;


                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Global.ErrorList.Clear();
                dataGridView1.DataSource = new List<ErrorList>();
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }

        private void Connect()
        {
            const string noConnectionMessage = "PLC bağlantısı kurulamadı Lütfen bağlantınızı kontrol ederek tekar deneyiniz.";

            try
            {
                if (!Client.ConnectionStatus) Client.UaConnection();
            }
            catch (Exception exception)
            {
                Global.ErrorToDatabase("ReConnection", "Error",
                    exception.Message == "BadRequestTimeout" ? noConnectionMessage : exception.Message, exception);
            }
            finally
            {
                LoadList();
            }
        }

        private void BtnReConnection_Click(object sender, EventArgs e)
        {
            using (var waitForm = new WaitFormTransparent(Connect, "Yeniden bağlanıyor..."))
            {
                waitForm.ShowDialog(this);
            }
        }
    }
}
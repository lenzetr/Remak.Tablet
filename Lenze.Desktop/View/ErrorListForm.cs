using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            dataGridView1.DataSource = Global.ErrorList;

            dataGridView1.Columns["Module"].Width = 150;
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Message"].Width = 450;
            dataGridView1.Columns["Exception"].Width = 300;

            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Global.ErrorList.Clear();
            dataGridView1.DataSource = new List<ErrorList>();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void Connect()
        {
            try
            {
                if (!Client.ConnectionStatus) Client.UaConnection();
            }
            catch (Exception exception)
            {
                Global.ErrorList.Add(
                    new ErrorList
                    {
                        Module = "ReConnection",
                        Name = "Error",
                        Message = exception.Message,
                        Exception = exception.ToString()
                    }
                );
            }
            finally
            {
                try
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch (Exception)
                {
                    //
                }
                finally
                {
                    LoadList();
                }
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
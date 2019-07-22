using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace SQL_Server_Compare
{
    public partial class TableComparer : Form
    {
        SqlConnection sqlConnectionForTable1ForComparison = null;
        SqlConnection sqlConnectionForTable2ForComparison = null;

        public TableComparer()
        {
            InitializeComponent();
        }

        private void TableComparer_Load(object sender, EventArgs e)
        {

        }

        internal void compareTables()
        {
            string databaseServerName1 = sqlConnectionForTable1ForComparison.DataSource;
            string databaseName1 = sqlConnectionForTable1ForComparison.Database;
            string table1ForComparison = table1ComboBox.Text;
            string databaseServerName2 = sqlConnectionForTable2ForComparison.DataSource;
            string databaseName2 = sqlConnectionForTable2ForComparison.Database;
            string table2ForComparison = table2ComboBox.Text;

            string tabPageName = databaseServerName1 + "." + databaseName1 + "." + table1ForComparison + " and " + databaseServerName2 + "." + databaseName2 + "." + table2ForComparison + " comparison";

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, table1DataGridView, new object[] { true });
            using (SqlConnection tempSqlConnection = new SqlConnection(sqlConnectionForTable1ForComparison.ConnectionString))
            {
                try
                {
                    string sqlQuery = "select column_name 'Column Name', data_type 'Data Type', character_maximum_length 'Maximum Length', IS_NULLABLE as 'Is Nullable', NUMERIC_PRECISION as 'Numeric Precision', DATETIME_PRECISION as 'DateTime Precision' from information_schema.columns where table_name = '" + table1ForComparison + "'";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlQuery, tempSqlConnection);
                    DataSet ds = new DataSet();
                    sqlDA.Fill(ds);
                    DataView source = new DataView(ds.Tables[0]);

                    table1DataGridView.DataError += new DataGridViewDataErrorEventHandler(dataGridViewIgnoreError);
                    table1DataGridView.DataSource = source;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occurred. Error: " + exc.Message);
                }
            }
            
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, table2DataGridView, new object[] { true });
            using (SqlConnection tempSqlConnection = new SqlConnection(sqlConnectionForTable2ForComparison.ConnectionString))
            {
                string sqlQuery = "select column_name 'Column Name', data_type 'Data Type', character_maximum_length 'Maximum Length', IS_NULLABLE as 'Is Nullable', NUMERIC_PRECISION as 'Numeric Precision', DATETIME_PRECISION as 'DateTime Precision' from information_schema.columns where table_name = '" + table2ForComparison + "'";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlQuery, tempSqlConnection);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);


                table2DataGridView.DataError += new DataGridViewDataErrorEventHandler(dataGridViewIgnoreError);
                table2DataGridView.DataSource = source;
            }

            compareAndColorDataGridViews(table1DataGridView, table2DataGridView);
            compareAndColorDataGridViews(table2DataGridView, table1DataGridView);
        }

        private void compareAndColorDataGridViews(DataGridView dgv1, DataGridView dgv2)
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                string fieldName = dgv1["Column Name", i].Value.ToString();
                string maximumLength = dgv1["Maximum Length", i].Value.ToString();
                string dataType = dgv1["Data Type", i].Value.ToString();
                string isNullable = dgv1["Is Nullable", i].Value.ToString();
                string numericPrecision = dgv1["Numeric Precision", i].Value.ToString();
                string dateTimePrecision = dgv1["DateTime Precision", i].Value.ToString();
                bool fieldExistsIn2ndDataGridView = false;
                for (int j = 0; j < dgv2.Rows.Count; j++)
                {
                    if (dgv2["Column Name", j].Value.ToString() == fieldName)
                    {
                        if (dgv2["Maximum Length", j].Value.ToString() != maximumLength)
                        {
                            dgv2["Maximum Length", j].Style.BackColor = Color.Red;
                        }
                        if (dgv2["Data Type", j].Value.ToString() != dataType)
                        {
                            dgv2["Data Type", j].Style.BackColor = Color.Red;
                        }
                        if (dgv2["Is Nullable", j].Value.ToString() != isNullable)
                        {
                            dgv2["Is Nullable", j].Style.BackColor = Color.Red;
                        }
                        if (dgv2["Numeric Precision", j].Value.ToString() != numericPrecision)
                        {
                            dgv2["Numeric Precision", j].Style.BackColor = Color.Red;
                        }
                        if (dgv2["DateTime Precision", j].Value.ToString() != dateTimePrecision)
                        {
                            dgv2["DateTime Precision", j].Style.BackColor = Color.Red;
                        }
                        fieldExistsIn2ndDataGridView = true;
                        break;
                    }
                }

                if (!fieldExistsIn2ndDataGridView)
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        protected void dataGridViewIgnoreError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void changeTable1ConnectionButton_Click(object sender, EventArgs e)
        {
            changeTableConnection(ref sqlConnectionForTable1ForComparison, table1ComboBox, table1Label, changeTable1ConnectionButton);
        }

        private void changeTable2ConnectionButton_Click(object sender, EventArgs e)
        {
            changeTableConnection(ref sqlConnectionForTable2ForComparison, table2ComboBox, table2Label, changeTable2ConnectionButton);
        }

        private void changeTableConnection(ref SqlConnection sqlConnectionToSet, ComboBox comboBoxToFill, Label labelToChange, Button buttonToChange)
        {
            string tempSqlConnection = getConnectionStringFromDialog("", "", false);
            if (tempSqlConnection != null)
            {
                sqlConnectionToSet = new SqlConnection(tempSqlConnection);

                string databaseServerName = sqlConnectionToSet.DataSource;
                string databaseName = sqlConnectionToSet.Database;

                labelToChange.Text = databaseServerName + "." + databaseName;

                fillTableComboBox(sqlConnectionToSet, comboBoxToFill);
                buttonToChange.Text = "Change Connection";
                labelToChange.Visible = true;
            }
        }

        private void fillTableComboBox(SqlConnection sqlConnection, ComboBox comboBox)
        {
            using (SqlConnection tempSqlConnection = new SqlConnection(sqlConnection.ConnectionString))
            {
                string sqlQuery = "select table_name from INFORMATION_SCHEMA.tables where table_type <> 'VIEW' order by table_name";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlQuery, tempSqlConnection);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                comboBox.DataSource = source;
                comboBox.DisplayMember = "table_name";
            }
        }

        private void runComparisonButton_Click(object sender, EventArgs e)
        {
            compareTables();
        }

        internal static string getConnectionStringFromDialog(string server, string authenticationType, bool chooseServerOnly)
        {
            DatabaseConnectionProperties dcp = new DatabaseConnectionProperties();
            dcp.ChooseDBServerOnly = chooseServerOnly;
            dcp.DatabaseServerName = server;

            if (dcp.ShowDialog() == DialogResult.OK)
            {
                return dcp.ResultingSQLConnection.ConnectionString;
            }
            else
            {
                return null;
            }

        }
    }
}

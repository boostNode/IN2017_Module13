/*
 *  Author: Troy Davis
 *  Project: Module13 - ExampleAzureDB - Windows Form Application (with database, ADO.NET)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 30, 2017 
 *  Revision: Original
 *  
 *  NOTE: see Program.cs for comprehensive notes
 */



using System;
using DT = System.Data;            // System.Data.dll  
using QC = System.Data.SqlClient;  // System.Data.dll
using System.Windows.Forms;

namespace ExampleAzureDB
{
    public partial class frmAzureExample : Form
    {
        // Form variables
        QC.SqlConnection dbConnection = null;
        QC.SqlCommand dbCommand = null;
        QC.SqlDataReader dbReader = null;
        String strResult;
        String strRemarks;

        public frmAzureExample(QC.SqlConnection connection, String strIN)
        {
            dbConnection = connection;
            InitializeComponent();
            lblResult.Text = "Connection String:\n\n" + dbConnection.ConnectionString;
            lblRemarks.Text = strIN;
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {           
            lblResult.Text = "";
            lblRemarks.Text = "Executing Database Query";

            //  Execute T-SQL Query
            try
            {
                using (dbCommand = new QC.SqlCommand())
                {
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandType = DT.CommandType.Text;
                    dbCommand.CommandText = @"
                        SELECT
                            * 
                        FROM
                            Contacts AS c
                        ORDER BY
                            c.ContactLast, 
                            c.ContactFirst
                        ;
                    ";

                    dbReader = dbCommand.ExecuteReader();

                    strResult = "";
                    while (dbReader.Read())
                    {
                        strResult += "ID(" + dbReader.GetInt32(0) + ") - " + dbReader.GetString(1) + ", " + dbReader.GetString(2) + " - " + dbReader.GetString(5) + ", " + dbReader.GetString(6) + "\n";
                    }

                    dbReader.Close();
                }
                strRemarks = "Executing Database Query - success";
            }
            catch (Exception ex2)
            {
                strResult = "Exception:\n\n" + ex2;
                strRemarks = "Executing Database Query - failure";
            }
            
            lblResult.Text = strResult;
            lblRemarks.Text = strRemarks;
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblRemarks.Text = "Executing Database Query";

            //  Execute T-SQL Query
            try
            {
                using (dbCommand = new QC.SqlCommand())
                {
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandType = DT.CommandType.Text;
                    dbCommand.CommandText = @"
                        SELECT
                            * 
                        FROM
                            Contacts AS c
                        WHERE
                            c.ContactFirst LIKE 'R%'
                        ORDER BY
                            c.ContactLast, 
                            c.ContactFirst
                        ;
                    ";

                    dbReader = dbCommand.ExecuteReader();

                    strResult = "";
                    while (dbReader.Read())
                    {
                        strResult += "ID(" + dbReader.GetInt32(0) + ") - " + dbReader.GetString(1) + ", " + dbReader.GetString(2) + " - " + dbReader.GetString(5) + ", " + dbReader.GetString(6) + "\n";
                    }

                    dbReader.Close();
                }
                strRemarks = "Executing Database Query - success";
            }
            catch (Exception ex2)
            {
                strResult = "Exception:\n\n" + ex2;
                strRemarks = "Executing Database Query - failure";
            }

            lblResult.Text = strResult;
            lblRemarks.Text = strRemarks;
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblRemarks.Text = "Executing Database Query";

            //  Execute T-SQL Query
            try
            {
                using (dbCommand = new QC.SqlCommand())
                {
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandType = DT.CommandType.Text;
                    dbCommand.CommandText = @"
                        SELECT
                            * 
                        FROM
                            Contacts AS c
                        WHERE
                            c.ContactState = 'KS'
                        ORDER BY
                            c.ContactLast, 
                            c.ContactFirst
                        ;
                    ";

                    dbReader = dbCommand.ExecuteReader();

                    strResult = "";
                    while (dbReader.Read())
                    {
                        strResult += "ID(" + dbReader.GetInt32(0) + ") - " + dbReader.GetString(1) + ", " + dbReader.GetString(2) + " - " + dbReader.GetString(5) + ", " + dbReader.GetString(6) + "\n";
                    }

                    dbReader.Close();
                }
                strRemarks = "Executing Database Query - success";
            }
            catch (Exception ex2)
            {
                strResult = "Exception:\n\n" + ex2;
                strRemarks = "Executing Database Query - failure";
            }

            lblResult.Text = strResult;
            lblRemarks.Text = strRemarks;
        }
    }
}

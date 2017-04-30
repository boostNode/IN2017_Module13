/*
 *  Author: Troy Davis
 *  Project: Module13 - ExampleAzureDB - Windows Form Application (with database, ADO.NET)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 30, 2017 
 *  Revision: Original
 *  
 *  For more information on displaying related data on Windows Forms, see:
 *      https://msdn.microsoft.com/en-us/library/57tx3hhe(v=vs.110)
 * 
 *  Resources utilized to complete demo
 *      
 *      Azure SQL Database Demo:
 *      
 *          Setup Free Account / Trial Subscription: https://azure.microsoft.com/en-us/
 *          
 *          Add SQL Database: (tutorial links here) https://docs.microsoft.com/en-us/azure/sql-database/
 *              Azure Portal Tutorial: https://docs.microsoft.com/en-us/azure/sql-database/sql-database-get-started-portal
 *                  Setup SQL Database (requires Microsoft SQL Server) - Basic $4.99/mo - free trial ($200 credit for 1st month)
 *                  Setup Resource Group
 *                  Setup SQL Server
 *                  Setup Server Firewall Rule (note: make sure you click "Save" after "Add client IP" so it actually updates your profile)
 *                  
 *          Create Visual Studio Project:
 *          
 *              Connection and Query Tutorial:
 *              
 *                  (1) Install .NET (already part of Visual Studio ... just emphasized in the event using different language/IDE)
 *                  
 *                  (2) Add Data Client to App (C# Console Example Dependency)
 *                      open Visual Studio
 *                      add a new project (demos uses console apps, but you can do windows form apps by tweaking code if you desire)
 *                      under Solution Explorer, select your solution (top line)
 *                      right-click and select "Properties"
 *                      expand "Common Properties" and select "Project Dependencies"
 *                      how ???
 *                      
 *                  (3) Setup Database Connection String (note: demo examples assume you used AdventureWorksLT as your database source ... modify if using your own db)
 *                      demo 1: uses SqlConnectionStringBuilder()
 *                          see this Visual Studio example:
 *                              https://docs.microsoft.com/en-us/azure/sql-database/sql-database-connect-query-dotnet
 *                          login to Azure
 *                              https://azure.microsoft.com/en-us/    
 *                              path 1: click on SQL Databases icon (left bar), select your database
 *                              path 2: click on Dashboard icon (left bar), under resources/subscriptions select your database
 *                          use the server/database info from Azure in the Visual Studio example
 *                              builder.DataSource = (your Azure server name, see Server name under Essentials)
 *                              builder.UserID = (you need to add a database user)
 *                                  Currently can't be done through Azure Portal, so use either SQL Server Management Studio or execute in Visual Studio
 *                                      Example 1: Add User with T-SQL:
 *                                          https://azure.microsoft.com/en-us/blog/adding-users-to-your-sql-azure-database/
 *                                      Example 2: see Non-administrator users (T-SQL):
 *                                          https://docs.microsoft.com/en-us/azure/sql-database/sql-database-manage-logins
 *                              builder.Password = (whatever you setup for your database user)
 *                              builder.InitialCatalog = (your Azure database name)
 *                      demo 2: general purpose (option 1) - use when connection will be dynamic, determined by app (user login, etc):
 *                          see this Visual Studio example:
 *                              https://docs.microsoft.com/en-us/sql/connect/ado-net/step-3-proof-of-concept-connecting-to-sql-using-ado-net
 *                          login to Azure
 *                              https://azure.microsoft.com/en-us/
 *                              path 1: click on SQL Databases icon (left bar), select your database
 *                              path 2: click on Dashboard icon (left bar), under resources/subscriptions select your database
 *                          use the connection string in Azure in the Visual Studio example
 *                              in Azure, under Essentials, Connection strings, click the "Show database connection strings" link
 *                              setup database user and password
 *                                  Currently can't be done through Azure Portal, so use either SQL Server Management Studio or execute in Visual Studio
 *                                      Example 1: Add User with T-SQL:
 *                                          https://azure.microsoft.com/en-us/blog/adding-users-to-your-sql-azure-database/
 *                                      Example 2: see Non-administrator users (T-SQL):
 *                                          https://docs.microsoft.com/en-us/azure/sql-database/sql-database-manage-logins
 *                              configure Azure connection string with user and password created
 *                      demo3: general purpose (option 2) - use when connection will be static for entire app:
 *                          see this Visual Studio example:
 *                              http://www.c-sharpcorner.com/uploadfile/5089e0/create-single-connection-string-for-all-windows-form-in-net/
 *                          remainder similar to demo 2
 *
 *                  (4) Grant User permissions on each table for user just created
 *                      see Examples, A. Granting SELECT permission on a table at:
 *                          https://docs.microsoft.com/en-us/sql/t-sql/statements/grant-object-permissions-transact-sql
 *                          
 *                  (5) Select/Insert/Update/Delete in App (follow sample code)	
 *                        
 */

using System;
using QC = System.Data.SqlClient;  // System.Data.dll
using System.Windows.Forms;

namespace ExampleAzureDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Main variables
            String dbServer;
            String dbName;
            String dbUserID;
            String dbPassword;
            String strConnection;
            String strResult;
            QC.SqlConnection dbConnection = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //////////////////////////////////////////////////////////////
            //  This app setup using demo 2 references (most generic)   //
            //////////////////////////////////////////////////////////////


            //  Setup Database Connection String (see Database Connection String from Azure)
            dbServer    = "boostnode.database.windows.net";
            dbName      = "myAzureDB";
            dbUserID    = "myTestUser";
            dbPassword  = "myTestPassword_IN2017!";

            strConnection = "Server = tcp:" + dbServer + ", 1433; " +
                            "Initial Catalog = " + dbName + "; " +
                            "Persist Security Info = False; " +
                            "User ID = " + dbUserID + "; " +
                            "Password = " + dbPassword + "; " +
                            "MultipleActiveResultSets = False; " +
                            "Encrypt = True; " +
                            "TrustServerCertificate = False; " +
                            "Connection Timeout = 30; ";

            /* optional
            dbConnection = new QC.SqlConnection
            (
                    @"Server = tcp:boostnode.database.windows.net, 1433;
                    Initial Catalog = myAzureDB;
                    Persist Security Info = False;
                    User ID = myTestUser;
                    Password = myTestPassword_IN2017!;
                    MultipleActiveResultSets = False;
                    Encrypt = True;
                    TrustServerCertificate = False;
                    Connection Timeout = 30;"
            );
            using (dbConnection)
            */
            using (dbConnection = new QC.SqlConnection(strConnection))
            {
                try
                {
                    dbConnection.Open();
                    strResult = "Connecting to Database: Success";
                    Application.Run(new frmAzureExample(dbConnection, strResult));
                }
                catch
                {
                    strResult = "Connecting to Database: Failure";
                }
            }
        }
    }
}

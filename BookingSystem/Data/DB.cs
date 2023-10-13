using BookingSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Data
{
    public class DB
    {
        #region Data Members

        private string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\Chiko-DK\\BookingSystem\\BookingSystem\\BookingDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        //private string strConn = Settings.Default.BookingDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;

        public enum DBOperation
        {
            Add,
            Edit,
            Delete
        }
        #endregion

        #region Constructor
        public DB()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Update DataSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();     // May remove after
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion

        #region update source 2
        public bool UpdateDataSource(DataSet dataSet, string tableName)
        {
            bool success;
            try
            {
                // Open the database connection
                cnMain.Open();

                // Create a new SqlDataAdapter for the specified table
                daMain = new SqlDataAdapter($"SELECT * FROM {tableName}", cnMain);

                // Create a SqlCommandBuilder to generate update commands
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daMain);

                // Get the changes made in the DataSet
                DataTable changesTable = dataSet.Tables[tableName].GetChanges();

                if (changesTable != null)
                {
                    // Update the data source with the changes
                    daMain.Update(changesTable);

                    // Accept the changes in the DataSet to clear the 'Modified' status
                    dataSet.Tables[tableName].AcceptChanges();
                    
                }
                success = true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during database access
                Console.WriteLine("An error occurred: " + ex.Message);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion

    }
}

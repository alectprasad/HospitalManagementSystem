using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace HMS
{
    class DBhelper
    {
        static OracleConnection conn;
        static OracleCommand comm;
        static OracleDataAdapter da;
        static DataTable dataTable;
        private static readonly string connectionString = "DATA SOURCE=DESKTOP-B2NCL0K:1521/XE;PERSIST SECURITY INFO=True;USER ID=DB;Password=password";

        public static Boolean login(String type, String id) {
            try
            {
                conn = new OracleConnection(connectionString);
                conn.Open();
                string mID = "";
                switch (type)
                {
                    case "Doctor":
                        mID = "D_ID";
                        break;
                    case "Nurse":
                        mID = "N_ID";
                        break;
                    case "Receptionist":
                        mID = "R_ID";
                        break;
                }
                comm = new OracleCommand
                {
                    CommandText = "select " + mID + " from " + type
                };
                OracleDataAdapter dataAdapter = new OracleDataAdapter(comm.CommandText, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Dispose();
            }
            foreach (DataRow dr in dataTable.Rows)
                {
                    if (dr[0].ToString() == id)
                    {
                        return true;
                    }
                }
                return false;
        }
        // This function takes an sql read command and returns a DataTable containing the result
         
        public static DataTable read(String command) { 
            conn = new OracleConnection(connectionString);
            conn.Open();
            comm = new OracleCommand
            {
                CommandText = command
            };
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comm.CommandText, conn);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conn.Dispose();
            return dataTable;
        }
    }
}

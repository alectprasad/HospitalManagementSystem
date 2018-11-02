using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        static OracleParameter op;
        private static readonly string connectionString = "DATA SOURCE=DESKTOP-B2NCL0K:1521/XE;PERSIST SECURITY INFO=True;USER ID=DB;Password=password";

        // This function takes an id and login type and validates login
        public static Boolean login(String type, String id)
        {
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

        public static DataTable read(String command)
        {
            try
            {
                conn = new OracleConnection(connectionString);
                conn.Open();
                comm = new OracleCommand
                {
                    CommandText = command
                };
                OracleDataAdapter dataAdapter = new OracleDataAdapter(comm.CommandText, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally { conn.Dispose(); }
            return dataTable;
        }

        public static void insert(String command)
        {
            try {
                conn = new OracleConnection(connectionString);
                conn.Open();
                comm = new OracleCommand { CommandText = command };
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Insertion successfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally { conn.Dispose(); }
        }

        public static void discharge(String pid, String ward)
        {
            try {
                conn = new OracleConnection(connectionString);
                conn.Open();
                comm = new OracleCommand("discharge", conn);
                comm.CommandText = "discharge";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("pid", OracleDbType.Varchar2).Value = pid;
                comm.Parameters.Add("wames", OracleDbType.Varchar2).Value = ward;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally { conn.Dispose();
                MessageBox.Show("success"); }
        }

        public static void discharge_doc(String pid, String dept)
        {
            try
            {
                conn = new OracleConnection(connectionString);
                conn.Open();
                comm = new OracleCommand("discharge_doc", conn);
                comm.CommandText = "discharge_doc";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("pid", OracleDbType.Varchar2).Value = pid;
                comm.Parameters.Add("dept", OracleDbType.Varchar2).Value = dept;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally
            {
                conn.Dispose();
                MessageBox.Show("success");
            }
        }

        public static void assign_doc(String pid)
        {
            try
            {
                conn = new OracleConnection(connectionString);
                conn.Open();
                comm = new OracleCommand("assign_doctor", conn);
                comm.CommandText = "assign_doctor";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("pid", OracleDbType.Varchar2).Value = pid;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally
            {
                conn.Dispose();
                MessageBox.Show("success");
            }
        }
    }
}

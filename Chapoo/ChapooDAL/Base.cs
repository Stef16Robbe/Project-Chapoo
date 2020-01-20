using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChapooDAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        public SqlConnection conn;
        
        public Base()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapooDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        // Open connection with database
        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        // Close connection with database
        private void CloseConnection()
        {
            conn.Close();
        }

        // For Insert/Update/Delete Queries with transaction
        protected void ExecuteEditTranQuery(String query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        // For Insert/Update/Delete Queries 
        protected void ExecuteEditQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Insert/Edit/Update without parameters
        protected void ExecuteEditQuery(String query)
        {
            SqlCommand command = new SqlCommand();
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }
        }

        // For Select Queries
        protected DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Error.WriteLine(e.Message);
                return null;
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}

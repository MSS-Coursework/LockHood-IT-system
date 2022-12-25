using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockHood
{
    class databaseClass
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConnString = "Data Source=(local);Initial Catalog=LockHood;Integrated Security=True";


        //create connection to database function
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)//check connection state currently
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL CONNECTION FAILED " + ex.Message, "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //function to close the database connection
        public void closeConn()
        {
            connection.Close();
        }



        //read data through sql data adapter and fill it to a data table
        public void readDatathroughAdapter(string query, DataTable dt)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL DATA READ FAILED " + ex.Message, "DATA ADAPTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public SqlDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SqlDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL DATA READ FAILED " + ex.Message, "DATA READER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        //execute custom query and return an int of rows effected by the query.
        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL QUERY " + ex.Message, "DATA ADAPTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw ex;
            }
        }
        //run a query and get the data into a datagrid view using the readDatathrough adapter method
        public void showData(string query, DataGridView dtgv)
        {

            try
            {

                DataTable dt = new DataTable();
                dt.Rows.Clear();

                readDatathroughAdapter(query, dt);
                if (dt.Rows.Count > 0)
                {
                    dtgv.DataSource = dt;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            closeConn();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.DataUtil
{
    
    class dataUtil
    {

        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");


        // This method will get data from database
        public DataTable Select()
        {
            DataTable data = new DataTable();

            try
            {
                String query = "SELECT * FROM tbl_admissionForm";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(data);




            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured",ex);
            }
            finally
            {
                conn.Close();

            }
            return data;
        }

        // This method will delete data from database
        public bool Delete(int index)
        {

            // Creating a default return type and setting its values to false
            bool isSuccess = false;



            try
            {
                //sql to delete data from database
                String sql = "DELETE FROM  tbl_admissionForm WHERE id=@id";

                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creaating Parameters to delete Values
                cmd.Parameters.AddWithValue("@id", index);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if query runs successfully than row value will be greater than 0 else data is not entered   successffully.
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught", ex);
            }
            finally
            {
                //Close the Connection
                conn.Close();
            }

            return isSuccess;

        }

        /// <summary>
        /// This Method will provide selected data to the fee Form 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public DataTable searchById(int id)
        {
            DataTable data = new DataTable();

            try
            {
                String query = "SELECT fullName,degree  FROM tbl_admissionForm WHERE id=@id ";
                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(query, conn);
                // Creaating Parameters to delete Values
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured", ex);
            }
            finally
            {
                conn.Close();

            }
            return data;

        }

        // This Method will display the fee Detail ..............................

        public DataTable GetFeeData()
        {
            DataTable data = new DataTable();

            try
            {
                String query = "SELECT * FROM tbl_feeForm";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(data);




            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured", ex);
            }
            finally
            {
                conn.Close();

            }
            return data;
        }







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DVLD_DataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        public static bool FindTestTypeByTestTypeID( int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref decimal testFees )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestTypes WHERE TestTypeID = @testTypeID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testTypeTitle = reader[ "TestTypeTitle" ].ToString();
                    testTypeDescription = reader[ "TestTypeDescription" ].ToString();
                    testFees = decimal.Parse( reader[ "TestTypeFees" ].ToString() );
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool FindTestTypeByTestTypeTitle( string testTypeTitle, ref int testTypeID, ref string testTypeDescription, ref decimal testFees )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestTypes WHERE TestTypeTitle = @testTypeTitle";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testTypeTitle", testTypeTitle );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    testTypeDescription = reader[ "TestTypeDescription" ].ToString();
                    testFees = decimal.Parse( reader[ "TestTypeFees" ].ToString() );
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static DataTable GetAllTestTypes()
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM TestTypes";
            SqlCommand cmd = new SqlCommand( query, con );
            // cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load( reader );
                return dt;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool AddTestType( string testTypeTitle, string testTypeDescription, decimal testFees )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO TestTypes VALUES ( @testTypeTitle, @testTypeDescription, @testFees )";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@testTypeTitle", testTypeTitle );
            cmd.Parameters.AddWithValue( "@testTypeDescription", testTypeDescription );
            cmd.Parameters.AddWithValue( "@testFees", testFees );
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if ( rowsAffected > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool UpdateTestType( int testTypeID, string testTypeTitle, string testTypeDescription, decimal testFees )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE TestTypes SET TestTypeTitle = @testTypeTitle, TestTypeDescription = @testTypeDescription, TestTypeFees = @testFees WHERE TestTypeID = @testTypeID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            cmd.Parameters.AddWithValue( "@testTypeTitle", testTypeTitle );
            cmd.Parameters.AddWithValue( "@testTypeDescription", testTypeDescription );
            cmd.Parameters.AddWithValue( "@testFees", testFees );
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if ( rowsAffected > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM ApplicationTypes";
            SqlCommand cmd = new SqlCommand( query, connect );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    dt.Load( reader );
                }
                else
                {
                    dt = null;
                }

            }
            catch ( Exception ex )
            {

                //do nothing
            }
            finally
            {
                connect.Close();
            }
            return dt;

        }
        public static bool FindApplicationTypeByID( int id, ref string applicationTitle, ref decimal applicationFees )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM ApplicationTypes WHERE ApplicationTypeID = @id";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", id );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    applicationTitle = ( string ) reader[ "ApplicationTypeTitle" ];
                    applicationFees = ( decimal ) reader[ "ApplicationFees" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool UpdateApplicationType( int ID, string applicationTypeTitle, decimal applicationTypeFees )
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE ApplicationTypes SET 
                            ApplicationTypeTitle    = @applicationTypeTitle,
                            ApplicationFees         = @applicationTypeFees
                            WHERE ApplicationTypeID = @applicationTypID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationTypID", ID );
            cmd.Parameters.AddWithValue( "@applicationTypeTitle", applicationTypeTitle );
            cmd.Parameters.AddWithValue( "@applicationTypeFees", applicationTypeFees );

            try
            {
                connection.Open();
                rowAffected = cmd.ExecuteNonQuery();

            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowAffected > 0 );
        }
    }
}

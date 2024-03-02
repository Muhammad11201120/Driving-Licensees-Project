using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {
        public static DataTable GetAllLocalDrivingLicesnseApllications()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM LocalDrivingLicenseApplications";
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
                reader.Close();
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
        public static bool FindLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID( int localDrivingLicenseApplicationID, ref int licenseClassID, ref int applicationID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    licenseClassID = ( int ) reader[ "LicenseClassID" ];
                    applicationID = ( int ) reader[ "ApplicationID" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindLocalDrivingLicenseApplicationByLicenseClassID( ref int localDrivingLicenseApplicationID, int licenseClassID, ref int applicationID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM LocalDrivingLicenseApplications WHERE LicenseClassID = @licenseClassID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@licenseClassID", licenseClassID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    localDrivingLicenseApplicationID = ( int ) reader[ "LocalDrivingLicenseApplicationID" ];
                    applicationID = ( int ) reader[ "ApplicationID" ];
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
        // find local driving license application by application id
        public static bool FindLocalDrivingLicenseApplicationByApplicationID( int applicationID, ref int localDrivingLicenseApplicationID, ref int licenseClassID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @applicationID ORDER BY ApplicationID DESC";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    localDrivingLicenseApplicationID = ( int ) reader[ "LocalDrivingLicenseApplicationID" ];
                    licenseClassID = ( int ) reader[ "LicenseClassID" ];
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
        public static int AddNewLocalDrivingLicenseApplication( int licenseClassID, int applicationID )
        {
            int localDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO LocalDrivingLicenseApplications (LicenseClassID, ApplicationID) VALUES (@licenseClassID, @applicationID); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@licenseClassID", licenseClassID );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                localDrivingLicenseApplicationID = Convert.ToInt32( cmd.ExecuteScalar() );
            }
            catch ( System.Exception ex )
            {
                localDrivingLicenseApplicationID = -1;
            }
            finally
            {
                connection.Close();
            }
            return localDrivingLicenseApplicationID;
        }
        public static bool UpdateLocalDrivingLicenseApplication( int localDrivingLicenseApplicationID, int licenseClassID, int applicationID )
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE LocalDrivingLicenseApplications SET LicenseClassID = @licenseClassID, ApplicationID = @applicationID WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            cmd.Parameters.AddWithValue( "@licenseClassID", licenseClassID );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                isUpdated = true;
            }
            catch ( System.Exception ex )
            {
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }
        public static bool DeleteLocalDrivingLicenseApplication( int localDrivingLicenseApplicationID )
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                isDeleted = true;
            }
            catch ( System.Exception ex )
            {
                isDeleted = false;
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }
    }
}

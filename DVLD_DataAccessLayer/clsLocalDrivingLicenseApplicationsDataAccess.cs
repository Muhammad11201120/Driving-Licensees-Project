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
            string query = "SELECT top 1 * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";
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
                isFound = false;
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
    }
}

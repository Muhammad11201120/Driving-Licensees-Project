using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsLocalDrivingLicenseApplications_ViewDataAccess
    {
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";
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
        public static bool FindLocalDrivingLicenseApplicationByID( int applicationID, ref string className, ref string nationalNO, ref string fullName, ref DateTime ApplicationDate, ref int passedTestCount, ref string status )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"SELECT TOP 1 * FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID =@applicationID ";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    className = ( string ) reader[ "ClassName" ];
                    nationalNO = ( string ) reader[ "NationalNo" ];
                    fullName = ( string ) reader[ "FullName" ];
                    ApplicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    passedTestCount = ( int ) reader[ "PassedTestCount" ];
                    status = ( string ) reader[ "Status" ];
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
        public static bool FindLocalDrivingLicenseApplicationByNationalNO( ref int applicationID, ref string className, string nationalNO, ref string fullName, ref DateTime ApplicationDate, ref int passedTestCount, ref string status )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"SELECT TOP 1 * FROM LocalDrivingLicenseApplications_View WHERE NationalNo =@nationalNO ";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@nationalNO", nationalNO );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    className = ( string ) reader[ "ClassName" ];
                    applicationID = ( int ) reader[ "LocalDrivingLicenseApplicationID" ];
                    fullName = ( string ) reader[ "FullName" ];
                    ApplicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    passedTestCount = ( int ) reader[ "PassedTestCount" ];
                    status = ( string ) reader[ "Status" ];
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
        public static int AddNewLocalDrivingLicenseApplication( string className, string nationalNO, string fullNName, DateTime applicationDate, int passedTestCount, string status )
        {
            int LocalLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"INSERT INTO LocalDrivingLicenseApplications_View (ClassName,NationalNo,FullName,ApplicationDate,PassedTestCount,Status) 
                            VALUES 
                            (@className,@nationalNO,@fullNName,@applicationDate,@passedTestCount,@status);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@className", className );
            cmd.Parameters.AddWithValue( "@nationalNO", nationalNO );
            cmd.Parameters.AddWithValue( "@fullNName", fullNName );
            cmd.Parameters.AddWithValue( "@ApplicationDate", applicationDate );
            cmd.Parameters.AddWithValue( "@passedTestCount", passedTestCount );
            cmd.Parameters.AddWithValue( "@status", status );

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    LocalLicenseApplicationID = insertedID;
                }
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return LocalLicenseApplicationID;
        }
        public static bool UpdateLocalDrivingLicenseApplication( int localDrivingLicenseApplicationID, string className, string nationalNO, string fullName, DateTime applicationDate, int passedTestCount, string status )
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE LocalDrivingLicenseApplications_View SET 
                            ClassName = @className,
                            NationalNo = @NationalNO,
                            FullName = @fullName ,
                            ApplicationDate = @applicationDate,
                            PassedTestCount= @passedTestCount,
                            Status= @status                         
                            WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            cmd.Parameters.AddWithValue( "@className", className );
            cmd.Parameters.AddWithValue( "@nationalNO", nationalNO );
            cmd.Parameters.AddWithValue( "@fullNName", fullName );
            cmd.Parameters.AddWithValue( "@passedTestCount", passedTestCount );
            cmd.Parameters.AddWithValue( "@status", status );

            try
            {
                connection.Open();
                object result = cmd.ExecuteNonQuery();
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return rowAffected > 0;
        }
        public static bool IsLocalDrivingLicenseApplicationExist( int localLicenseApplicationID )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM People WHERE LocalDrivingLicenseApplications_View = @localLicenseApplicationID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@localLicenseApplicationID", localLicenseApplicationID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch ( Exception ex )
            {
                isFound = false;
            }
            finally
            {
                connect.Close();
            }
            return isFound;
        }
    }
}

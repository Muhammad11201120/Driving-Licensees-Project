using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLD_DataAccessLayer
{
    public class clsTestsDatatAccess
    {
        public static bool FindTestByTestID( int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Tests WHERE testID = @testID";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testID", testID );
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = ( int ) reader[ "testAppointmentID" ];
                    testResult = ( bool ) reader[ "testResult" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                    createdByUserID = ( int ) reader[ "createdByUserID" ];
                    return true;
                }
                else
                    return false;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool FindTestByTestAppointmentID( int testAppointmentID, ref int testID, ref bool testResult, ref string notes, ref int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Tests WHERE testAppointmentID = @testAppointmentID ORDER BY TestID DESC";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testID = ( int ) reader[ "testID" ];
                    testResult = ( bool ) reader[ "testResult" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                    createdByUserID = ( int ) reader[ "createdByUserID" ];
                    return true;
                }
                else
                    return false;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool FindTestByTestResult( bool testResult, ref int testID, ref int testAppointmentID, ref string notes, ref int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Tests WHERE testResult = @testResult";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testResult", testResult );
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testID = ( int ) reader[ "testID" ];
                    testAppointmentID = ( int ) reader[ "testAppointmentID" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                    createdByUserID = ( int ) reader[ "createdByUserID" ];
                    return true;
                }
                else
                    return false;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static int AddNewTest( int testAppointmentID, bool testResult, string notes, int createdByUserID )
        {
            int testID = -1;
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO Tests (testAppointmentID, testResult, notes, createdByUserID) VALUES (@testAppointmentID, @testResult, @notes, @createdByUserID);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            cmd.Parameters.AddWithValue( "@testResult", testResult );
            if ( notes != "" )
            {
                cmd.Parameters.AddWithValue( "@notes", notes );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@notes", System.DBNull.Value );
            }
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    testID = insertedID;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return testID;
        }
        public static bool UpdateTest( int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE Tests SET testAppointmentID = @testAppointmentID, testResult = @testResult, notes = @notes, createdByUserID = @createdByUserID WHERE testID = @testID";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testID", testID );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            cmd.Parameters.AddWithValue( "@testResult", testResult );
            if ( notes != "" )
            {
                cmd.Parameters.AddWithValue( "@notes", notes );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@notes", System.DBNull.Value );
            }
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if ( rowsAffected == 1 )
                    return true;
                else
                    return false;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool DoesAttendTestType( int localDrivingLicenseID, int testTypeID )
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"SELECT FOUND = 1 from Tests  INNER JOIN
                            TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                            LocalDrivingLicenseApplications ON 
                            TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID 
                            where TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseID and TestAppointments.TestTypeID = @testTypeID";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseID", localDrivingLicenseID );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isFound;
        }
        public static bool DoesPassTestType( int localDrivingLicenseID, int testTypeID )
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"SELECT FOUND = 1 from Tests  INNER JOIN
                            TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                            LocalDrivingLicenseApplications ON 
                            TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID 
                            where TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseID and TestAppointments.TestTypeID = @testTypeID and Tests.TestResult = 1";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseID", localDrivingLicenseID );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isFound;
        }
    }
}

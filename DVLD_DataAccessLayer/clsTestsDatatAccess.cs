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
                    notes = ( string ) reader[ "notes" ];
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
            string query = "SELECT * FROM Tests WHERE testAppointmentID = @testAppointmentID";
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
                    notes = ( string ) reader[ "notes" ];
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
        public static bool AddNewTest( int testAppointmentID, bool testResult, string notes, int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO Tests (testAppointmentID, testResult, notes, createdByUserID) VALUES (@testAppointmentID, @testResult, @notes, @createdByUserID)";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            cmd.Parameters.AddWithValue( "@testResult", testResult );
            cmd.Parameters.AddWithValue( "@notes", notes );
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
        public static bool UpdateTest( int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID )
        {
            SqlConnection conn = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE Tests SET testAppointmentID = @testAppointmentID, testResult = @testResult, notes = @notes, createdByUserID = @createdByUserID WHERE testID = @testID";
            SqlCommand cmd = new SqlCommand( query, conn );
            cmd.Parameters.AddWithValue( "@testID", testID );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            cmd.Parameters.AddWithValue( "@testResult", testResult );
            cmd.Parameters.AddWithValue( "@notes", notes );
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLD_DataAccessLayer
{
    public class clsTestAppointmentsDataAccess
    {
        public static DataTable GetAllTestAppoinments()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM TestAppointments";
            SqlCommand cmd = new SqlCommand( query, connect );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    dt.Load( reader );
                    return dt;
                }
                else
                {
                    dt = null;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable GetAllTestAppoinmentsByLocalDrivingLicenseApplicatioID( int localDrivingLicenseApplicationID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID ORDER BY TestAppointmentID DESC";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    dt.Load( reader );
                    return dt;
                }
                else
                {
                    dt = null;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static bool FindTestAppoinmentByTestAppoinmentID( int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime testAppointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE TestAppointmentID = @testAppoinmentID ";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testAppoinmentID", testAppointmentID );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    testAppointmentDate = DateTime.Parse( reader[ "AppointmentDate" ].ToString() );
                    paidFees = decimal.Parse( reader[ "PaidFees" ].ToString() );
                    createdByUserID = int.Parse( reader[ "CreatedByUserID" ].ToString() );
                    isLocked = bool.Parse( reader[ "IsLocked" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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
        public static bool IsTestAppoinmentExists( int testAppoinmentID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM TestAppointments WHERE TestAppointmentID = @testAppoinmentID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testAppoinmentID", testAppoinmentID );
            try
            {
                con.Open();
                int rowsAffected = ( int ) cmd.ExecuteScalar();
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
        public static int TestAppoinmentByIdCount( int testAppoinmentID )
        {

            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM TestAppointments WHERE TestAppointmentID = @testAppoinmentID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testAppoinmentID", testAppoinmentID );
            try
            {
                con.Open();
                int rowsAffected = ( int ) cmd.ExecuteScalar();
                return rowsAffected;
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
        public static int AddTestAppoinment( int testTypeID, int localDrivingLicenseApplicationID, DateTime testAppointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID )
        {
            int appointmentID = -1;
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) VALUES (@testTypeID, @localDrivingLicenseApplicationID, @AppointmentDate, @paidFees, @createdByUserID, @isLocked, @retakeTestApplicationID);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            cmd.Parameters.AddWithValue( "@AppointmentDate", testAppointmentDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@isLocked", isLocked );
            if ( retakeTestApplicationID != -1 )
            {
                cmd.Parameters.AddWithValue( "@retakeTestApplicationID", retakeTestApplicationID );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@retakeTestApplicationID", System.DBNull.Value );
            }

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    appointmentID = insertedID;
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
            return appointmentID;
        }
        public static bool UpdateTestAppoinment( int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime testAppointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE TestAppointments SET TestTypeID = @testTypeID, LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID, AppointmentDate = @AppointmentDate, PaidFees = @paidFees, CreatedByUserID = @createdByUserID, IsLocked = @isLocked, RetakeTestApplicationID = @retakeTestApplicationID WHERE TestAppointmentID = @testAppointmentID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testAppointmentID", testAppointmentID );
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            cmd.Parameters.AddWithValue( "@AppointmentDate", testAppointmentDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@isLocked", isLocked );
            if ( retakeTestApplicationID != -1 )
            {
                cmd.Parameters.AddWithValue( "@retakeTestApplicationID", retakeTestApplicationID );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@retakeTestApplicationID", System.DBNull.Value );
            }
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

        public static bool DeleteTestAppoinment( int testAppoinmentID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            SqlCommand cmd = new SqlCommand( "DeleteTestAppoinment", con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@testAppoinmentID", testAppoinmentID );
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
        public static bool FindTestAppointmentByTestTypeID( int testTypeID, ref int testAppointmentID, ref int localDrivingLicenseApplicationID, ref DateTime testAppointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE TestTypeID = @testTypeID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@testTypeID", testTypeID );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = int.Parse( reader[ "TestAppointmentID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    testAppointmentDate = DateTime.Parse( reader[ "AppointmentDate" ].ToString() );
                    paidFees = decimal.Parse( reader[ "PaidFees" ].ToString() );
                    createdByUserID = int.Parse( reader[ "CreatedByUserID" ].ToString() );
                    isLocked = bool.Parse( reader[ "IsLocked" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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
        public static bool FindTestAppointmentByLocalDrivingLicenseApplicationID( int localDrivingLicenseApplicationID, ref int testAppointmentID, ref int testTypeID, ref DateTime testAppointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID ORDER BY TestAppointmentID DESC";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = ( int ) reader[ "TestAppointmentID" ];
                    testTypeID = ( int ) reader[ "TestTypeID" ];
                    testAppointmentDate = ( DateTime ) reader[ "AppointmentDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    isLocked = ( bool ) reader[ "IsLocked" ];
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }

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
        public static bool FindTestAppointmentByTestAppointmentDate( DateTime testAppointmentDate, ref int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE TestAppointmentDate = @testAppointmentDate";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@testAppointmentDate", testAppointmentDate );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = int.Parse( reader[ "TestAppointmentID" ].ToString() );
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    paidFees = decimal.Parse( reader[ "PaidFees" ].ToString() );
                    createdByUserID = int.Parse( reader[ "CreatedByUserID" ].ToString() );
                    isLocked = bool.Parse( reader[ "IsLocked" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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
        public static bool FindTestAppointmentByPaidFees( decimal paidFees, ref int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime testAppointmentDate, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE PaidFees = @paidFees";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = int.Parse( reader[ "TestAppointmentID" ].ToString() );
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    testAppointmentDate = DateTime.Parse( reader[ "AppointmentDate" ].ToString() );
                    createdByUserID = int.Parse( reader[ "CreatedByUserID" ].ToString() );
                    isLocked = bool.Parse( reader[ "IsLocked" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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
        public static bool FindTestAppointmentByCreatedByUserID( int createdByUserID, ref int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime testAppointmentDate, ref decimal paidFees, ref bool isLocked, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE CreatedByUserID = @createdByUserID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = int.Parse( reader[ "TestAppointmentID" ].ToString() );
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    testAppointmentDate = DateTime.Parse( reader[ "AppointmentDate" ].ToString() );
                    paidFees = decimal.Parse( reader[ "PaidFees" ].ToString() );
                    isLocked = bool.Parse( reader[ "IsLocked" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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
        public static bool FindTestAppointmentByIsLocked( bool isLocked, ref int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime testAppointmentDate, ref decimal paidFees, ref int createdByUserID, ref int retakeTestApplicationID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM TestAppointments WHERE IsLocked = @isLocked";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@isLocked", isLocked );
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    testAppointmentID = int.Parse( reader[ "TestAppointmentID" ].ToString() );
                    testTypeID = int.Parse( reader[ "TestTypeID" ].ToString() );
                    localDrivingLicenseApplicationID = int.Parse( reader[ "LocalDrivingLicenseApplicationID" ].ToString() );
                    testAppointmentDate = DateTime.Parse( reader[ "AppointmentDate" ].ToString() );
                    paidFees = decimal.Parse( reader[ "PaidFees" ].ToString() );
                    createdByUserID = int.Parse( reader[ "CreatedByUserID" ].ToString() );
                    if ( reader[ "RetakeTestApplicationID" ] != DBNull.Value )
                    {
                        retakeTestApplicationID = ( int ) reader[ "RetakeTestApplicationID" ];
                    }
                    else
                    {
                        retakeTestApplicationID = -1;
                    }
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

        public static bool IsTestAppointmentExists( int testAppoinmentID )
        {
            SqlConnection con = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM TestAppointments WHERE TestAppointmentID = @testAppoinmentID";
            SqlCommand cmd = new SqlCommand( query, con );
            cmd.Parameters.AddWithValue( "@testAppoinmentID", testAppoinmentID );
            try
            {
                con.Open();
                int rowsAffected = ( int ) cmd.ExecuteScalar();
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

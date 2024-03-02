using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace DVLD_DataAccessLayer
{
    public class clsInternationalLicenseDataAccess
    {
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string sql = "SELECT * FROM InternationalLicenses";
            SqlCommand cmd = new SqlCommand( sql, connect );
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
        public static DataTable GetInterNationalLicensesByDriverID( int driverID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string sql = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";
            SqlCommand cmd = new SqlCommand( sql, connect );
            cmd.Parameters.AddWithValue( "@DriverID", driverID );
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
        public static DataTable GetAllInterNationalLicensesByInterNationalLicenseID( int internationalLicenseID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string sql = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand( sql, connect );
            cmd.Parameters.AddWithValue( "@InternationalLicenseID", internationalLicenseID );
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
        public static DataTable GetAllInterNationalLicnsesByApllicationID( int applicationID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string sql = "SELECT * FROM InternationalLicenses WHERE ApplicationID = @ApplicationID";
            SqlCommand cmd = new SqlCommand( sql, connect );
            cmd.Parameters.AddWithValue( "@ApplicationID", applicationID );
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
        public static DataTable GetAllInternationalLicensesByLocalLicenseID( int localLicenseID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string sql = "SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";
            SqlCommand cmd = new SqlCommand( sql, connect );
            cmd.Parameters.AddWithValue( "@IssuedUsingLocalLicenseID", localLicenseID );
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
        public static bool FindInterNationalLicenseByInterNationalLicenseID( int internationalLicenseId, ref int applicationID, ref int driverID, ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expiryDate, ref bool isActive, ref int createdByUserID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@InternationalLicenseID", internationalLicenseId );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    reader.Read();
                    applicationID = Convert.ToInt32( reader[ "ApplicationID" ] );
                    driverID = Convert.ToInt32( reader[ "DriverID" ] );
                    issuedUsingLocalLicenseID = Convert.ToInt32( reader[ "IssuedUsingLocalLicenseID" ] );
                    issueDate = Convert.ToDateTime( reader[ "IssueDate" ] );
                    expiryDate = Convert.ToDateTime( reader[ "ExpirationDate" ] );
                    isActive = Convert.ToBoolean( reader[ "IsActive" ] );
                    createdByUserID = Convert.ToInt32( reader[ "CreatedByUserID" ] );
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
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
        }
        public static int AddNewInternationalLicense( int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expiryDate, bool isActive, int createdByUserID )
        {
            int licenseID = -1;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"INSERT INTO InternationalLicenses 
                            (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) 
                            VALUES
                            (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpiryDate, @IsActive, @CreatedByUserID);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@ApplicationID", applicationID );
            cmd.Parameters.AddWithValue( "@DriverID", driverID );
            cmd.Parameters.AddWithValue( "@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID );
            cmd.Parameters.AddWithValue( "@IssueDate", issueDate );
            cmd.Parameters.AddWithValue( "@ExpiryDate", expiryDate );
            cmd.Parameters.AddWithValue( "@IsActive", isActive );
            cmd.Parameters.AddWithValue( "@CreatedByUserID", createdByUserID );
            try
            {
                connect.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    licenseID = insertedID;
                }
            }
            catch ( System.Exception ex )
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return licenseID;
        }
        public static bool UpdateInternationalLicense( int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expiryDate, bool isActive, int createdByUserID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE InternationalLicenses SET ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, IssueDate = @IssueDate, ExpirationDate = @ExpiryDate, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@InternationalLicenseID", internationalLicenseID );
            cmd.Parameters.AddWithValue( "@ApplicationID", applicationID );
            cmd.Parameters.AddWithValue( "@DriverID", driverID );
            cmd.Parameters.AddWithValue( "@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID );
            cmd.Parameters.AddWithValue( "@IssueDate", issueDate );
            cmd.Parameters.AddWithValue( "@ExpiryDate", expiryDate );
            cmd.Parameters.AddWithValue( "@IsActive", isActive );
            cmd.Parameters.AddWithValue( "@CreatedByUserID", createdByUserID );
            try
            {
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if ( rows > 0 )
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
                connect.Close();
            }
        }
        public static bool DeleteInternationalLicense( int internationalLicenseID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@InternationalLicenseID", internationalLicenseID );
            try
            {
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if ( rows > 0 )
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
                connect.Close();
            }
        }
        public static bool isInternationalLicenseExists( int internationalLicenseID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 InternationalLicenseID FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@InternationalLicenseID", internationalLicenseID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
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
        }
        public static bool FindInternationalLicenseByApplicationID( ref int internationalLicenseID, int applicationID, ref int driverID, ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expiryDate, ref bool isActive, ref int createdByUserID )
        {

            SqlConnection sqlConnection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM InternationalLicenses WHERE ApplicationID = @ApplicationID";
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection );
            sqlCommand.Parameters.AddWithValue( "@ApplicationID", applicationID );
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if ( reader.HasRows )
                {
                    reader.Read();
                    internationalLicenseID = Convert.ToInt32( reader[ "InternationalLicenseID" ] );
                    driverID = Convert.ToInt32( reader[ "DriverID" ] );
                    issuedUsingLocalLicenseID = Convert.ToInt32( reader[ "IssuedUsingLocalLicenseID" ] );
                    issueDate = Convert.ToDateTime( reader[ "IssueDate" ] );
                    expiryDate = Convert.ToDateTime( reader[ "ExpirationDate" ] );
                    isActive = Convert.ToBoolean( reader[ "IsActive" ] );
                    createdByUserID = Convert.ToInt32( reader[ "CreatedByUserID" ] );
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static bool FindInternationalLicenseByDriverID( ref int internationalLicenseID, ref int applicationID, int driverID, ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expiryDate, ref bool isActive, ref int createdByUserID )
        {
            SqlConnection sqlConnection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM InternationalLicenses WHERE DriverID = @DriverID";
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection );
            sqlCommand.Parameters.AddWithValue( "@DriverID", driverID );
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if ( reader.HasRows )
                {
                    reader.Read();
                    internationalLicenseID = Convert.ToInt32( reader[ "InternationalLicenseID" ] );
                    applicationID = Convert.ToInt32( reader[ "ApplicationID" ] );
                    issuedUsingLocalLicenseID = Convert.ToInt32( reader[ "IssuedUsingLocalLicenseID" ] );
                    issueDate = Convert.ToDateTime( reader[ "IssueDate" ] );
                    expiryDate = Convert.ToDateTime( reader[ "ExpirationDate" ] );
                    isActive = Convert.ToBoolean( reader[ "IsActive" ] );
                    createdByUserID = Convert.ToInt32( reader[ "CreatedByUserID" ] );
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static bool FindInternationalLicenseByLocalLicenseID( ref int internationalLicenseID, ref int applicationID, ref int driverID, int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expiryDate, ref bool isActive, ref int createdByUserID )
        {
            SqlConnection sqlConnection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection );
            sqlCommand.Parameters.AddWithValue( "@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID );
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if ( reader.HasRows )
                {
                    reader.Read();
                    internationalLicenseID = Convert.ToInt32( reader[ "InternationalLicenseID" ] );
                    applicationID = Convert.ToInt32( reader[ "ApplicationID" ] );
                    driverID = Convert.ToInt32( reader[ "DriverID" ] );
                    issueDate = Convert.ToDateTime( reader[ "IssueDate" ] );
                    expiryDate = Convert.ToDateTime( reader[ "ExpirationDate" ] );
                    isActive = Convert.ToBoolean( reader[ "IsActive" ] );
                    createdByUserID = Convert.ToInt32( reader[ "CreatedByUserID" ] );
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static int InternationalLicensesCounts()
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM InternationalLicenses";
            SqlCommand cmd = new SqlCommand( query, connect );
            try
            {
                connect.Open();
                int count = ( int ) cmd.ExecuteScalar();
                return count;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}

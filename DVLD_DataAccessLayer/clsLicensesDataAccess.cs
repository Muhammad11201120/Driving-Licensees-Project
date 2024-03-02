using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Licenses";
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
        public static bool FindLicenseByLicenseID( int licenseID, ref int driverID, ref int applicatioID, ref int licenseClass, ref DateTime issueDate, ref DateTime expiryDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Licenses WHERE LicenseID = @licenseID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@licenseID", licenseID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    driverID = ( int ) reader[ "DriverID" ];
                    applicatioID = ( int ) reader[ "ApplicationID" ];
                    licenseClass = ( int ) reader[ "LicenseClass" ];
                    issueDate = ( DateTime ) reader[ "IssueDate" ];
                    expiryDate = ( DateTime ) reader[ "ExpirationDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    isActive = ( bool ) reader[ "IsActive" ];
                    issueReason = ( byte ) reader[ "IssueReason" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                }
                reader.Close();
            }
            catch ( Exception ex )
            {
                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindLicenseByDriverID( int driverID, ref int licenseID, ref int applicatioID, ref int licenseClass, ref DateTime issueDate, ref DateTime expiryDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Licenses WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    licenseID = ( int ) reader[ "LicenseID" ];
                    applicatioID = ( int ) reader[ "ApplicationID" ];
                    licenseClass = ( int ) reader[ "LicenseClass" ];
                    issueDate = ( DateTime ) reader[ "IssueDate" ];
                    expiryDate = ( DateTime ) reader[ "ExpirationDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    isActive = ( bool ) reader[ "IsActive" ];
                    issueReason = ( byte ) reader[ "IssueReason" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                }
                reader.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindLicenseByApplicationID( int applicationID, ref int licenseID, ref int driverID, ref int licenseClass, ref DateTime issueDate, ref DateTime expiryDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Licenses WHERE ApplicationID = @applicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    licenseID = ( int ) reader[ "LicenseID" ];
                    driverID = ( int ) reader[ "DriverID" ];
                    licenseClass = ( int ) reader[ "LicenseClass" ];
                    issueDate = ( DateTime ) reader[ "IssueDate" ];
                    expiryDate = ( DateTime ) reader[ "ExpirationDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    isActive = ( bool ) reader[ "IsActive" ];
                    issueReason = ( byte ) reader[ "IssueReason" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    if ( reader[ "Notes" ] != DBNull.Value )
                    {
                        notes = ( string ) reader[ "Notes" ];
                    }
                    else
                    {
                        notes = string.Empty;
                    }
                }
                reader.Close();
            }
            catch ( Exception ex )
            {
                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool DeleteLicense( int licenseID )
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM Licenses WHERE LicenseID = @licenseID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@licenseID", licenseID );
            try
            {
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                if ( rows > 0 )
                {
                    isDeleted = true;
                }
                else
                {
                    isDeleted = false;
                }
            }
            catch ( Exception ex )
            {
                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }
        public static int AddLicense( int driverID, int applicationID, int licenseClass, DateTime issueDate, DateTime expiryDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID )
        {
            int isAdded = -1;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO Licenses (DriverID,ApplicationID ,LicenseClass, IssueDate, ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) VALUES (@driverID,@applicationID, @licenseTypeID, @issueDate, @expiryDate,@notes,@paidFees,@isActive,@issueReason,@createdByUserID);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            cmd.Parameters.AddWithValue( "@licenseTypeID", licenseClass );
            cmd.Parameters.AddWithValue( "@issueDate", issueDate );
            cmd.Parameters.AddWithValue( "@expiryDate", expiryDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@isActive", isActive );
            cmd.Parameters.AddWithValue( "@issueReason", issueReason );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            if ( notes != "" )
            {
                cmd.Parameters.AddWithValue( "@notes", notes );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@notes", System.DBNull.Value );
            }
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    isAdded = insertedID;
                }
            }
            catch ( System.Exception ex )
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isAdded;

        }
        public static bool UpdateLicense( int licenseID, int driverID, int applicationID, int licenseClass, DateTime issueDate, DateTime expiryDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID )
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE Licenses SET DriverID = @driverID, ApplicationID = @applicationID, LicenseClass = @licenseClass, IssueDate = @issueDate, ExpirationDate = @expiryDate, Notes = @notes, PaidFees = @paidFees, IsActive = @isActive, IssueReason = @issueReason, CreatedByUserID = @createdByUserID WHERE LicenseID = @licenseID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@licenseID", licenseID );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            cmd.Parameters.AddWithValue( "@licenseClass", licenseClass );
            cmd.Parameters.AddWithValue( "@issueDate", issueDate );
            cmd.Parameters.AddWithValue( "@expiryDate", expiryDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@isActive", isActive );
            cmd.Parameters.AddWithValue( "@issueReason", issueReason );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            if ( notes != "" )
            {
                cmd.Parameters.AddWithValue( "@notes", notes );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@notes", System.DBNull.Value );
            }
            try
            {
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                if ( rows > 0 )
                {
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
            }
            catch ( Exception ex )
            {
                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }
        public static bool IsLicenseExists( int licenseID )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM Licenses WHERE LicenseID = @licenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@licenseID", licenseID );
            try
            {
                connect.Open();
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
                connect.Close();
            }
            return isFound;
        }
        public static bool IsLicenseExists( int driverID, int applicationID, int licenseClass )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM Licenses WHERE DriverID = @driverID AND ApplicationID = @applicationID AND LicenseClass = @licenseClass";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            cmd.Parameters.AddWithValue( "@licenseClass", licenseClass );
            try
            {
                connect.Open();
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
                connect.Close();
            }
            return isFound;
        }
        public static DataTable FindLicenseesByLicenseClassID( int licenseClassID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Licenses WHERE LicenseClass = @licenseClassID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@licenseClassID", licenseClassID );
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
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindLicensesByDriverID( int driverID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Licenses WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
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
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindLicensesByApplicationID( int applicationID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Licenses WHERE ApplicationID = @applicationID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
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
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
    }
}

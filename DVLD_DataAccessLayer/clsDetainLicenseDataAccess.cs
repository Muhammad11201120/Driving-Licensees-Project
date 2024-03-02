using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
namespace DVLD_DataAccessLayer
{
    public class clsDetainLicenseDataAccess
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "select * from DetainedLicenses_View";
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
                throw ex;
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static bool FindDetainLicenseByDetainID( int detainID, ref int licenseID, ref DateTime detainDate, ref decimal FineFees, ref int createdByUserID, ref bool isReleased, ref DateTime releasedDate, ref int releasedByUserId, ref int releaseApplicationID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "select TOP 1 * from DetainedLicenses where DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@DetainID", detainID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    reader.Read();
                    licenseID = ( int ) reader[ "LicenseID" ];
                    detainDate = ( DateTime ) reader[ "DetainDate" ];
                    FineFees = ( decimal ) reader[ "FineFees" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    isReleased = reader[ "IsReleased" ] == DBNull.Value ? false : ( bool ) reader[ "IsReleased" ];
                    releasedDate = reader[ "ReleaseDate" ] == DBNull.Value ? DateTime.Now : ( DateTime ) reader[ "ReleaseDate" ];
                    releasedByUserId = reader[ "ReleasedByUserID" ] == DBNull.Value ? -1 : ( int ) reader[ "ReleasedByUserID" ];
                    releaseApplicationID = reader[ "ReleaseApplicationID" ] == DBNull.Value ? -1 : ( int ) reader[ "ReleaseApplicationID" ];
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
        public static bool FindDetainLicenseByLicenseID( int licenseID, ref int detainID, ref DateTime detainDate, ref decimal FineFees, ref int createdByUserID, ref bool isReleased, ref DateTime releasedDate, ref int releasedByUserId, ref int releaseApplicationID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "select TOP 1 * from DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseID", licenseID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    detainID = ( int ) reader[ "DetainID" ];
                    detainDate = ( DateTime ) reader[ "DetainDate" ];
                    FineFees = ( decimal ) reader[ "FineFees" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    isReleased = reader[ "IsReleased" ] == DBNull.Value ? false : ( bool ) reader[ "IsReleased" ];
                    releasedDate = reader[ "ReleaseDate" ] == DBNull.Value ? DateTime.Now : ( DateTime ) reader[ "ReleaseDate" ];
                    releasedByUserId = reader[ "ReleasedByUserID" ] == DBNull.Value ? -1 : ( int ) reader[ "ReleasedByUserID" ];
                    releaseApplicationID = reader[ "ReleaseApplicationID" ] == DBNull.Value ? -1 : ( int ) reader[ "ReleaseApplicationID" ];
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
        public static bool AddNewDetainLicense( ref int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime releasedDate, int releasedByUserID, int releaseApplicationID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseID", licenseID );
            cmd.Parameters.AddWithValue( "@DetainDate", detainDate );
            cmd.Parameters.AddWithValue( "@FineFees", fineFees );
            cmd.Parameters.AddWithValue( "@CreatedByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@IsReleased", isReleased );
            cmd.Parameters.AddWithValue( "@ReleaseDate", releasedDate );
            cmd.Parameters.AddWithValue( "@ReleasedByUserID", releasedByUserID );
            cmd.Parameters.AddWithValue( "@ReleaseApplicationID", releaseApplicationID );
            try
            {
                connect.Open();
                detainID = Convert.ToInt32( cmd.ExecuteScalar() );
                return true;
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
        public static int AddNewDetainLicense( int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isRelaesed, DateTime releaseDate, int releasedByUserID, int releaseApplicationID )
        {
            int detainID = -1;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseID", licenseID );
            cmd.Parameters.AddWithValue( "@DetainDate", detainDate );
            cmd.Parameters.AddWithValue( "@FineFees", fineFees );
            cmd.Parameters.AddWithValue( "@CreatedByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@IsReleased", isRelaesed );
            cmd.Parameters.AddWithValue( "@ReleaseDate", releaseDate );
            cmd.Parameters.AddWithValue( "@ReleasedByUserID", releasedByUserID );
            cmd.Parameters.AddWithValue( "@ReleaseApplicationID", releaseApplicationID );
            try
            {
                connect.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    detainID = insertedID;
                }
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connect.Close();
            }
            return detainID;
        }
        public static bool UpdateDetainLicense( int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime releasedDate, int releasedByUserID, int releaseApplicationID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "update DetainedLicenses set LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees, CreatedByUserID = @CreatedByUserID, IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID where DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@DetainID", detainID );
            cmd.Parameters.AddWithValue( "@LicenseID", licenseID );
            cmd.Parameters.AddWithValue( "@DetainDate", detainDate );
            cmd.Parameters.AddWithValue( "@FineFees", fineFees );
            cmd.Parameters.AddWithValue( "@CreatedByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@IsReleased", isReleased );
            cmd.Parameters.AddWithValue( "@ReleaseDate", releasedDate );
            cmd.Parameters.AddWithValue( "@ReleasedByUserID", releasedByUserID );
            cmd.Parameters.AddWithValue( "@ReleaseApplicationID", releaseApplicationID );
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                return true;
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
        public static bool DeleteDetainLicense( int detainID )
        {
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "delete from DetainedLicenses where DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@DetainID", detainID );
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                return true;
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

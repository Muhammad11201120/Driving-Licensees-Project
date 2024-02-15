using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesClassesDataAccess
    {
        public static DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM LicenseClasses";
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
        //find license class by licenseclassID
        public static bool FindClassByID( int licenseClassID, ref string className, ref string classDescription, ref byte minumumAllowAge, ref byte DefaultValidationLength, ref decimal classFees )
        {
            bool found = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseClassID", licenseClassID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    found = true;
                    className = reader[ "ClassName" ].ToString();
                    classDescription = reader[ "ClassDescription" ].ToString();
                    minumumAllowAge = ( byte ) reader[ "MinimumAllowedAge" ];
                    DefaultValidationLength = ( byte ) reader[ "DefaultValidityLength" ];
                    classFees = ( decimal ) reader[ "ClassFees" ];
                }
                else
                {
                    found = false;
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
            return found;
        }
        public static bool FindClassByName( ref int licenseClassID, string className, ref string classDescription, ref byte minumumAllowAge, ref byte DefaultValidationLength, ref decimal classFees )
        {
            bool found = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM LicenseClasses WHERE ClassName=@ClassName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@ClassName", className );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    found = true;
                    licenseClassID = ( int ) reader[ "LicenseClassID" ];
                    classDescription = reader[ "ClassDescription" ].ToString();
                    minumumAllowAge = ( byte ) reader[ "MinimumAllowedAge" ];
                    DefaultValidationLength = ( byte ) reader[ "DefaultValidityLength" ];
                    classFees = ( decimal ) reader[ "ClassFees" ];
                }
                else
                {
                    found = false;
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
            return found;
        }
        public static bool IsClassExist( int licenseClassID )
        {
            bool found = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseClassID", licenseClassID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    found = true;
                }
                else
                {
                    found = false;
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
            return found;
        }
        public static bool IsClassExist( string className )
        {
            bool found = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM LicenseClasses WHERE ClassName=@ClassName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@ClassName", className );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.HasRows )
                {
                    found = true;
                }
                else
                {
                    found = false;
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
            return found;
        }
        // Add new Class
        public static int AddNewLicenseClass( string className, string classDescription, int minimumAllowedAge, int defaultValidationLength, decimal classFees )
        {
            int licenseClassID = -1;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidationLength, ClassFees) VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidationLength, @ClassFees); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@ClassName", className );
            cmd.Parameters.AddWithValue( "@ClassDescription", classDescription );
            cmd.Parameters.AddWithValue( "@MinimumAllowedAge", minimumAllowedAge );
            cmd.Parameters.AddWithValue( "@DefaultValidationLength", defaultValidationLength );
            cmd.Parameters.AddWithValue( "@ClassFees", classFees );
            try
            {
                connect.Open();
                licenseClassID = Convert.ToInt32( cmd.ExecuteScalar() );
            }
            catch ( Exception ex )
            {

                //do nothing
            }
            finally
            {
                connect.Close();
            }
            return licenseClassID;
        }
        public static bool UpdateLicenseClass( int licenseClassID, string className, string classDescription, int minimumAllowedAge, int defaultValidationLength, decimal classFees )
        {
            bool updated = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE LicenseClasses SET ClassName=@ClassName, ClassDescription=@ClassDescription, MinimumAllowedAge=@MinimumAllowedAge, DefaultValidationLength=@DefaultValidationLength, ClassFees=@ClassFees WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseClassID", licenseClassID );
            cmd.Parameters.AddWithValue( "@ClassName", className );
            cmd.Parameters.AddWithValue( "@ClassDescription", classDescription );
            cmd.Parameters.AddWithValue( "@MinimumAllowedAge", minimumAllowedAge );
            cmd.Parameters.AddWithValue( "@DefaultValidationLength", defaultValidationLength );
            cmd.Parameters.AddWithValue( "@ClassFees", classFees );
            try
            {
                connect.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if ( rowsAffected > 0 )
                {
                    updated = true;
                }
                else
                {
                    updated = false;
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
            return updated;
        }
        public static bool DeleteClass( int licenseClassID )
        {
            bool deleted = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@LicenseClassID", licenseClassID );
            try
            {
                connect.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if ( rowsAffected > 0 )
                {
                    deleted = true;
                }
                else
                {
                    deleted = false;
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
            return deleted;
        }
    }
}

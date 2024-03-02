using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DVLD_DataAccessLayer
{
    public class clsDriversDataAccess
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Drivers_View";
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
        public static bool FindDriverByDriverID( int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Drivers WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    personID = ( int ) reader[ "PersonID" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    createdDate = ( DateTime ) reader[ "CreatedDate" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindDriverByPersonID( int personID, ref int driverID, ref int createdByUserID, ref DateTime createdDate )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Drivers WHERE PersonID = @personID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@personID", personID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    driverID = ( int ) reader[ "DriverID" ];
                    createdByUserID = ( int ) reader[ "CreatedByUserID" ];
                    createdDate = ( DateTime ) reader[ "CreatedDate" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddDriver( int personID, int createdByUserID, DateTime createdDate )
        {
            int isAdded = -1;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate) VALUES (@personID, @createdByUserID, @createdDate);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@personID", personID );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@createdDate", createdDate );
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
        public static bool UpdateDriver( int driverID, int personID, int createdByUserID, DateTime createdDate )
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "UPDATE Drivers SET PersonID = @personID, CreatedByUserID = @createdByUserID, CreatedDate = @createdDate WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
            cmd.Parameters.AddWithValue( "@personID", personID );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );
            cmd.Parameters.AddWithValue( "@createdDate", createdDate );
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
            catch ( System.Exception ex )
            {
                //nothing
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

        public static bool DeleteDriver( int driverID )
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM Drivers WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@driverID", driverID );
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
            catch ( System.Exception ex )
            {
                //nothing
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

        public static int TotalDrivers()
        {
            int total = 0;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM Drivers";
            SqlCommand cmd = new SqlCommand( query, connect );
            try
            {
                connect.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int totallRows ) )
                {
                    total = totallRows;
                }
            }
            catch ( Exception ex )
            {

                //nothing
            }
            finally
            {
                connect.Close();
            }
            return total;
        }
        public static bool isDriverExists( int driverID )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM Drivers WHERE DriverID = @driverID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@nationalID", driverID );
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

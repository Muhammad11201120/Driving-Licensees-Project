using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static DataTable ShowAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Users";
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

        public static bool FindUserByUserID( int userID, ref int personID, ref string userName, ref string password, ref bool isActive )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM Users WHERE UserID = @userID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@userID", userID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    personID = ( int ) reader[ "PersonID" ];
                    userName = ( string ) reader[ "UserName" ];
                    password = ( string ) reader[ "Password" ];
                    isActive = ( bool ) reader[ "IsAvtive" ];

                }
                reader.Close();
            }
            catch
            {
                // isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindUserByUPersonID( ref int userID, int personID, ref string userName, ref string password, ref bool isActive )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Users WHERE PersonID = @personID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@personID", personID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    userID = ( int ) reader[ "UserID" ];
                    userName = ( string ) reader[ "UserName" ];
                    password = ( string ) reader[ "Password" ];
                    isActive = ( bool ) reader[ "IsActive" ];
                }
                reader.Close();
            }
            catch ( Exception ex )
            {
                clsErrorsDataAccess.Msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindUserByUserUserName( ref int userID, ref int personID, string userName, ref string password, ref bool isActive )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Users WHERE UserName = @UserName";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@UserName", userName );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    userID = ( int ) reader[ "UserID" ];
                    personID = ( int ) reader[ "PersonID" ];
                    password = ( string ) reader[ "Password" ];
                    isActive = ( bool ) reader[ "IsActive" ];

                }
                reader.Close();
            }
            catch
            {
                // isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddNewUser( int personID, string username, string password, bool isActive )
        {
            int userID = -1;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
                            VALUES
                            (@personID,@userName,@password,@isActive);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@personID", personID );
            cmd.Parameters.AddWithValue( "@username", username );
            cmd.Parameters.AddWithValue( "@password", password );
            cmd.Parameters.AddWithValue( "@isActive", isActive );

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    userID = insertedID;
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

            return userID;
        }
        public static bool UpdateUser( int userID, int personID, string userName, string password, bool isActive )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE Users SET 
                            UserID = @userId,
                            PersonID = @personId,
                            UserName = @userName ,
                            Password= @password,
                            IsActive= @isActive
                            WHERE UserID = @userId";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@userId", userID );
            cmd.Parameters.AddWithValue( "@personId", personID );
            cmd.Parameters.AddWithValue( "@userName", userName );
            cmd.Parameters.AddWithValue( "@password", password );
            cmd.Parameters.AddWithValue( "@isActive", isActive );
            try
            {
                connection.Open();
                rowaAffected = cmd.ExecuteNonQuery();

            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowaAffected > 0 );
        }
        public static bool ChangePassword( int userID, string password )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE Users SET 
                            Password= @password 
                            WHERE UserID = @userId";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@userId", userID );
            cmd.Parameters.AddWithValue( "@password", password );

            try
            {
                connection.Open();
                rowaAffected = cmd.ExecuteNonQuery();

            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowaAffected > 0 );

        }
        public static int TotalUsers()
        {
            int total = 0;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM Users";
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
        public static bool DeleteUser( int id )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM Users WHERE UserID = @id";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", id );
            try
            {
                connection.Open();
                rowaAffected = cmd.ExecuteNonQuery();
            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowaAffected > 0 );

        }
    }
}






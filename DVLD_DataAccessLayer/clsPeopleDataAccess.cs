using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool FindPeopleByID( int ID, ref string nationalID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT * FROM People WHERE PersonID = @id";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", ID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    nationalID = ( string ) reader[ "NationalID" ];
                    firstName = ( string ) reader[ "FirstName" ];
                    secondName = ( string ) reader[ "SecondName" ];
                    lastName = ( string ) reader[ "LastName" ];
                    dateOfBirth = ( DateTime ) reader[ "DateOfBirth" ];
                    gendor = ( byte ) reader[ "Gendor" ];
                    address = ( string ) reader[ "Address" ];
                    phone = ( string ) reader[ "Phone" ];
                    nationalityCountryID = ( int ) reader[ "NationalityCountryID" ];

                    // Handling Nullble Values In DataBase
                    if ( reader[ "ImagePath" ] != DBNull.Value )
                    {
                        imagePath = ( string ) reader[ "ImagePath" ];
                    }
                    else
                    {
                        imagePath = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "Email" ] != DBNull.Value )
                    {
                        email = ( string ) reader[ "Email" ];
                    }
                    else
                    {
                        email = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "ThirdName" ] != DBNull.Value )
                    {
                        thirdName = ( string ) reader[ "ThirdName" ];
                    }
                    else
                    {
                        thirdName = string.Empty;
                    }
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
        public static bool FindPeopleByFirstName( ref int ID, ref string nationalID, string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT * FROM People WHERE FirstName = @firstName";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@firstName", firstName );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "ID" ];
                    nationalID = ( string ) reader[ "nationalID" ];
                    secondName = ( string ) reader[ "SecondName" ];
                    lastName = ( string ) reader[ "LastName" ];
                    dateOfBirth = ( DateTime ) reader[ "DateOfBirth" ];
                    gendor = ( byte ) reader[ "Gendor" ];
                    address = ( string ) reader[ "Address" ];
                    phone = ( string ) reader[ "Phone" ];
                    nationalityCountryID = ( int ) reader[ "NationalityCountryID" ];

                    // Handling Nullble Values In DataBase
                    if ( reader[ "ImagePath" ] != DBNull.Value )
                    {
                        imagePath = ( string ) reader[ "ImagePath" ];
                    }
                    else
                    {
                        imagePath = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "Email" ] != DBNull.Value )
                    {
                        email = ( string ) reader[ "Email" ];
                    }
                    else
                    {
                        email = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "ThirdName" ] != DBNull.Value )
                    {
                        thirdName = ( string ) reader[ "ThirdName" ];
                    }
                    else
                    {
                        thirdName = string.Empty;
                    }
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
        public static bool FindPeopleByNationalID( ref int ID, string nationalID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT * FROM People WHERE NationalID = @nationalID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@nationalID", nationalID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "ID" ];
                    firstName = ( string ) reader[ "FirstName" ];
                    secondName = ( string ) reader[ "SecondName" ];
                    lastName = ( string ) reader[ "LastName" ];
                    dateOfBirth = ( DateTime ) reader[ "DateOfBirth" ];
                    gendor = ( byte ) reader[ "Gendor" ];
                    address = ( string ) reader[ "Address" ];
                    phone = ( string ) reader[ "Phone" ];
                    nationalityCountryID = ( int ) reader[ "NationalityCountryID" ];

                    // Handling Nullble Values In DataBase
                    if ( reader[ "ImagePath" ] != DBNull.Value )
                    {
                        imagePath = ( string ) reader[ "ImagePath" ];
                    }
                    else
                    {
                        imagePath = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "Email" ] != DBNull.Value )
                    {
                        email = ( string ) reader[ "Email" ];
                    }
                    else
                    {
                        email = string.Empty;
                    }
                    // Handling Nullble Values In DataBase
                    if ( reader[ "ThirdName" ] != DBNull.Value )
                    {
                        thirdName = ( string ) reader[ "ThirdName" ];
                    }
                    else
                    {
                        thirdName = string.Empty;
                    }
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
        public static DataTable showAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT * FROM People";
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
        public static int AddNewPerson( string nationalID, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, byte gendor, string address, string phone, string email, int nationalityCountryID, string imagePath )
        {
            // this function returns int so we will store it in this variable
            int contactID = -1;

            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = @"INSERT INTO People (NationalID,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) 
                            VALUES 
                            (@nationalID,@firstName,@secondName,@thirdName,@lastName,@dateOfBirth,@gendor,@address,@phone,@email,@nationalityCountryID,@ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@nationalID", nationalID );
            cmd.Parameters.AddWithValue( "@firstName", firstName );
            cmd.Parameters.AddWithValue( "@secondName", secondName );
            cmd.Parameters.AddWithValue( "@lastName", lastName );
            cmd.Parameters.AddWithValue( "@dateOfBirth", dateOfBirth );
            cmd.Parameters.AddWithValue( "@gendor", gendor );
            cmd.Parameters.AddWithValue( "@address", address );
            cmd.Parameters.AddWithValue( "@Phone", phone );
            cmd.Parameters.AddWithValue( "@nationalityCountryID", nationalityCountryID );


            if ( imagePath != "" )
            {
                cmd.Parameters.AddWithValue( "@imagePath", imagePath );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@imagePath", System.DBNull.Value );
            }
            if ( email != "" )
            {
                cmd.Parameters.AddWithValue( "@email", email );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@email", System.DBNull.Value );
            }
            if ( thirdName != "" )
            {
                cmd.Parameters.AddWithValue( "@thirdName", thirdName );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@thirdName", System.DBNull.Value );
            }


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    contactID = insertedID;
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
            return contactID;
        }
        public static bool UpdatePerson( int id, string nationalID, string firstName, string seconName, string thirdName, string lastName, DateTime dateOfBirth, byte gendor, string address, string phone, string email, int nationaityCountryID, string imagePath )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = @"UPDATE People SET 
                            NationalID = @nationalID,
                            FirstName = @firstName,
                            SecondName = @SecondName ,
                            ThirdName= @thirdName,
                            LastName= @lastName,
                            DateOfBirth= @dateOfBirth,
                            Gendor= @gendor,
                            Address= @address,
                            Phone= @phone,
                            Email=@email,
                            NationalityCountryID = @nationalityCountryID,
                            WHERE PersonID = @id";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", id );
            cmd.Parameters.AddWithValue( "@nationalID", nationalID );
            cmd.Parameters.AddWithValue( "@firstName", firstName );
            cmd.Parameters.AddWithValue( "@SecondName", seconName );
            cmd.Parameters.AddWithValue( "@lastName", lastName );
            cmd.Parameters.AddWithValue( "@dateOfBirth", dateOfBirth );
            cmd.Parameters.AddWithValue( "@gendor", dateOfBirth );
            cmd.Parameters.AddWithValue( "@address", address );
            cmd.Parameters.AddWithValue( "@phone", phone );
            cmd.Parameters.AddWithValue( "@NationalityCountryID", nationaityCountryID );

            if ( imagePath != "" )
            {
                cmd.Parameters.AddWithValue( "@imagePath", imagePath );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@imagePath", System.DBNull.Value );
            }
            if ( email != "" )
            {
                cmd.Parameters.AddWithValue( "@email", email );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@email", System.DBNull.Value );
            }
            if ( thirdName != "" )
            {
                cmd.Parameters.AddWithValue( "@thirdName", thirdName );
            }
            else
            {
                cmd.Parameters.AddWithValue( "@thirdName", System.DBNull.Value );
            }


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
            return ( rowaAffected > 0 ); ;
        }
        public static bool DeletePerson( int id )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "DELETE FROM People WHERE PersonID = @id";

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
        public static bool IsPersonExist( int id )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT FOUND = 1 FROM People WHERE PersonID = @id";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@id", id );
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
        public static int TotalPeople()
        {
            int total = 0;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.Contact_conString );
            string query = "SELECT COUNT(*) FROM People";
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
    }
}

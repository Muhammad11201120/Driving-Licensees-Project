using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool FindPersonByID( int ID, ref string nationalID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM People WHERE PersonID = @id";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", ID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    nationalID = ( string ) reader[ "NationalNo" ];
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

                // isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindPersonByFirstName( ref int ID, ref string nationalID, string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM People WHERE FirstName = @firstName";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@firstName", firstName );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "PersonID" ];
                    nationalID = ( string ) reader[ "nationalNO" ];
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
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE NationalNo = @nationalNO";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@nationalNO", nationalID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "PersonID" ];
                    firstName = ( string ) reader[ "FirstName" ];
                    secondName = ( string ) reader[ "SecondName" ];
                    lastName = ( string ) reader[ "LastName" ];
                    dateOfBirth = ( DateTime ) reader[ "DateOfBirth" ];
                    gendor = ( byte ) reader[ "Gendor" ];
                    phone = ( string ) reader[ "Phone" ];
                    address = ( string ) reader[ "Address" ];
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

                //
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindPersonByPhone( ref int ID, ref string nationalID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, string phone, ref string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM People WHERE Phone = @phone";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@phone", phone );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "PersonID" ];
                    nationalID = ( string ) reader[ "NationalNo" ];
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
        public static bool FindPersonByEmail( ref int ID, ref string nationalID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gendor, ref string address, ref string phone, string email, ref int nationalityCountryID, ref string imagePath )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM People WHERE Email = @email";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@email", email );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    ID = ( int ) reader[ "PersonID" ];
                    nationalID = ( string ) reader[ "NationalNo" ];
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
        public static DataTable ShowAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
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
        public static DataTable FindPeopleByID( string ID )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE PersonID = @personID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "personID", ID );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByNationalNO( string nationalNo )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE NationalNo = @nationalID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "nationalID", nationalNo );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByFirstName( string firstName )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE FirstName = @firstName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@firstName", firstName );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleBySecondName( string secondName )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE SecondName = @secondName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@secondName", secondName );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByThirdName( string thirdName )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE ThirdName = @thirdName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@thirdName", thirdName );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByLastName( string lastname )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE LastName = @lastName";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@lastName", lastname );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByEmail( string email )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE Email = @email";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@email", email );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByPhone( string phone )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE Phone = @phone";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@phone", phone );
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

                //Console.WriteLine( ex.Message );
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        public static DataTable FindPeopleByGendor( string gendor )
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM People WHERE Gendor = @gendor";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@gendor", gendor );
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

                //Console.WriteLine( ex.Message );
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
            int PersonID = -1;

            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) 
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
                    PersonID = insertedID;
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
            return PersonID;
        }
        public static bool UpdatePerson( int id, string nationalID, string firstName, string seconName, string thirdName, string lastName, DateTime dateOfBirth, byte gendor, string address, string phone, string email, int nationaityCountryID, string imagePath )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE People SET 
                            NationalNo = @nationalID,
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
                            ImagePath = @imagePath
                            WHERE PersonID = @id";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@id", id );
            cmd.Parameters.AddWithValue( "@nationalID", nationalID );
            cmd.Parameters.AddWithValue( "@firstName", firstName );
            cmd.Parameters.AddWithValue( "@SecondName", seconName );
            cmd.Parameters.AddWithValue( "@lastName", lastName );
            cmd.Parameters.AddWithValue( "@dateOfBirth", dateOfBirth );
            cmd.Parameters.AddWithValue( "@gendor", gendor );
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
            return ( rowaAffected > 0 );
        }
        public static bool DeletePerson( int id )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
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
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
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
        public static bool IsNationalIDExisits( string nationalID )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM People WHERE NationalNo = @nationalID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@nationalID", nationalID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch ( Exception ex )
            {
                //nothing
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
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
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

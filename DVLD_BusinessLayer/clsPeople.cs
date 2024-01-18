using DVLD_DataAccessLayer;
using System;
using System.Data;
namespace DVLD_BusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string nationalID { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string lastName { set; get; }
        public DateTime dateOfBirth { set; get; }
        public byte gendor { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int nationalityCountryID { get; set; }
        public string imagePath { get; set; }

        public clsPeople()
        {
            this.ID = -1;
            this.nationalID = "";
            this.firstName = string.Empty;
            this.secondName = string.Empty;
            this.thirdName = string.Empty;
            this.lastName = string.Empty;
            this.dateOfBirth = DateTime.Now;
            this.gendor = 0;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.email = string.Empty;
            this.nationalityCountryID = 1;
            this.imagePath = "";
            this.Mode = enMode.AddNew;
        }
        public clsPeople( int ID, string nationalID, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, byte gendor, string address, string phone, string email, int nationalityCountryID, string imagePath )
        {
            this.ID = ID;
            this.nationalID = nationalID;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gendor = gendor;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.nationalityCountryID = nationalityCountryID;
            this.imagePath = imagePath;
            this.Mode = enMode.Update;
        }
        public static DataTable AllPeopleList()
        {
            if ( clsPeopleDataAccess.ShowAllPeople() != null )
            {
                return clsPeopleDataAccess.ShowAllPeople();
            }
            return null;
        }
        public static clsPeople FindPersonByID( int ID )
        {

            string nationalID = "";
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0;
            string address = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = -1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPersonByID( ID, ref nationalID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPersonByFirstName( string FirstName )
        {
            int ID = -1;
            string nationalID = "";
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0;
            string address = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = 1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPersonByFirstName( ref ID, ref nationalID, FirstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, FirstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPersonByNationalID( string nationalID )
        {
            int ID = -1;
            string firstName = "";
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0;
            string address = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = 1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPeopleByNationalID( ref ID, nationalID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPersonByPhone( string phone )
        {
            int ID = -1;
            string nationalID = string.Empty;
            string firstName = "";
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0;
            string address = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = 1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPersonByPhone( ref ID, ref nationalID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPersonByEmail( string email )
        {
            int ID = -1;
            string nationalID = string.Empty;
            string firstName = "";
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0;
            string address = string.Empty;
            string phone = string.Empty;
            int nationalityCountryID = 1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPersonByEmail( ref ID, ref nationalID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static DataTable FindPeopleByID( string ID )
        {

            return clsPeopleDataAccess.FindPeopleByID( ID );
        }
        public static DataTable FindPeopleByNationalNO( string nationalNO )
        {
            return clsPeopleDataAccess.FindPeopleByNationalNO( nationalNO );
        }
        public static DataTable FindPeopleByFirstName( string firstName )
        {
            return clsPeopleDataAccess.FindPeopleByFirstName( firstName );
        }
        public static DataTable FindPeopleBySecondName( string secondName )
        {
            return clsPeopleDataAccess.FindPeopleBySecondName( secondName );
        }
        public static DataTable FindPeopleByThirdName( string thirdName )
        {
            return clsPeopleDataAccess.FindPeopleByThirdName( thirdName );
        }
        public static DataTable FindPeopleByLastName( string lastName )
        {
            return clsPeopleDataAccess.FindPeopleByLastName( lastName );
        }
        public static DataTable FindPeopleByEmail( string email )
        {
            return clsPeopleDataAccess.FindPeopleByEmail( email );
        }
        public static DataTable FindPeopleByPhone( string phone )
        {
            return clsPeopleDataAccess.FindPeopleByPhone( phone );
        }
        public static DataTable FindPeopleByGendor( string gendor )
        {
            return clsPeopleDataAccess.FindPeopleByGendor( gendor );
        }
        private bool _AddNewPerson()
        {
            this.ID = clsPeopleDataAccess.AddNewPerson( this.nationalID, this.firstName, this.secondName, this.thirdName, this.lastName, this.dateOfBirth, this.gendor, this.address, this.phone, this.email, this.nationalityCountryID, this.imagePath );
            return ( this.ID != -1 );
        }
        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson( this.ID, this.nationalID, this.firstName, this.secondName, this.thirdName, this.lastName, this.dateOfBirth, this.gendor, this.address, this.phone, this.email, this.nationalityCountryID, this.imagePath );
        }
        public static bool DeletePerson( int id )
        {
            if ( clsPeopleDataAccess.DeletePerson( id ) )
            {
                return true;
            }
            return false;
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewPerson() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static DataTable ShowAllPeople()
        {
            return clsPeopleDataAccess.ShowAllPeople();
        }
        public static bool IsPersonExist( int id )
        {
            return clsPeopleDataAccess.IsPersonExist( id );
        }
        public static bool IsNationalIDExist( string nationalID )
        {
            return clsPeopleDataAccess.IsNationalIDExisits( nationalID );
        }
        public static int TotalPeople()
        {
            return clsPeopleDataAccess.TotalPeople();
        }
    }
}

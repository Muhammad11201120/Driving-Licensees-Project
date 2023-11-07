using DVLD_DataAccessLayer;
using System;
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
            Mode = enMode.AddNew;
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
            Mode = enMode.Update;
        }

        public static clsPeople FindPeopleByID( int ID )
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
            int nationalityCountryID = 1;
            string imagePath = "";

            if ( clsPeopleDataAccess.FindPeopleByID( ID, ref nationalID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPeopleByFirstName( string FirstName )
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

            if ( clsPeopleDataAccess.FindPeopleByFirstName( ref ID, ref nationalID, FirstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath ) )
            {

                return new clsPeople( ID, nationalID, FirstName, secondName, thirdName, lastName, dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath );

            }
            else
            {
                return null;
            }
        }
        public static clsPeople FindPeopleByNationalID( string nationalID )
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
    }
}

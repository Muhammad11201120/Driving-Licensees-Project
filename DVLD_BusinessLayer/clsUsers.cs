using DVLD_DataAccessLayer;
using System.Data;
namespace DVLD_BusinessLayer
{
    public class clsUsers
    {
        private clsPeople _person;
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int _UserID { set; get; }
        public int _PersonID { set; get; }
        public string _Name { set; get; }
        public string _Password { set; get; }
        public bool _IsActive { set; get; }


        public clsUsers( int personID )
        {
            this._UserID = -1;
            this._PersonID = personID;
            this._Name = string.Empty;
            this._Password = string.Empty;
            this._IsActive = true;
            this.Mode = enMode.AddNew;
        }
        public clsUsers( int userID, int personID, string name, string password, bool isActive )
        {
            this._UserID = userID;
            this._PersonID = personID;
            this._Name = name;
            this._Password = password;
            this._IsActive = isActive;
            this.Mode = enMode.Update;
        }
        public static DataTable AllUsersList()
        {
            if ( clsUsersDataAccess.ShowAllUsers() != null )
            {
                return clsUsersDataAccess.ShowAllUsers();
            }
            return null;
        }
        public static clsUsers FindUserByUserID( int userID )
        {
            int personID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = true;

            if ( clsUsersDataAccess.FindUserByUserID( userID, ref personID, ref userName, ref password, ref isActive ) )
            {
                return new clsUsers( userID, personID, userName, password, isActive );
            }
            else
            {
                return null;
            }
        }
        public static clsUsers FindUserByPersonID( int personID )
        {
            int userID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = true;

            if ( clsUsersDataAccess.FindUserByUPersonID( ref userID, personID, ref userName, ref password, ref isActive ) )
            {
                return new clsUsers( userID, personID, userName, password, isActive );
            }
            else
            {
                clsErrorsBuessnisLayer.Msg = clsErrorsDataAccess.Msg;
                return null;
            }
        }
        public static clsUsers FindUserByUserName( string userName )
        {
            int userID = -1;
            int personID = -1;
            string password = string.Empty;
            bool isActive = true;

            if ( clsUsersDataAccess.FindUserByUserUserName( ref userID, ref personID, userName, ref password, ref isActive ) )
            {
                return new clsUsers( userID, personID, userName, password, isActive );
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewUser()
        {
            this._UserID = clsUsersDataAccess.AddNewUser( this._PersonID, this._Name, this._Password, this._IsActive );
            return ( this._UserID != -1 );
        }
        private bool _UpdateUser()
        {
            return clsUsersDataAccess.UpdateUser( this._UserID, this._PersonID, this._Name, this._Password, this._IsActive );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewUser() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public bool ChangePAssword( string password )
        {
            return clsUsersDataAccess.ChangePassword( this._UserID, password );
        }
        public static int TotalUsers()
        {
            return clsUsersDataAccess.TotalUsers();
        }
        public static bool DeleteUser( int id )
        {
            if ( clsUsersDataAccess.DeleteUser( id ) )
            {
                return true;
            }
            return false;
        }
    }
}

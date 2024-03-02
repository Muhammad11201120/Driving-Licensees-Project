using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public enMode Mode = enMode.UPDATE;
        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpiryDate = DateTime.Now;
            IsActive = true;
            CreatedByUserID = -1;
            Mode = enMode.ADDNEW;
        }
        public clsInternationalLicense( int InternationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issuedDate, DateTime expiryDate, bool isActive, int createdByUserID )
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate = issuedDate;
            this.ExpiryDate = expiryDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
            Mode = enMode.UPDATE;
        }
        public static DataTable GetAllInterNationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
        }
        public static DataTable GetAllInternationalLicensesByLocalLicenseID()
        {
            if ( clsInternationalLicenseDataAccess.GetAllInternationalLicenses() != null )
            {
                return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
            }
            else
            {
                return null;
            }
        }
        public static DataTable FindLicensesByDriverID( int DriverID )
        {
            return clsInternationalLicenseDataAccess.GetInterNationalLicensesByDriverID( DriverID );
        }
        public static clsInternationalLicense FindInternationalLicenseByID( int InternationalLicenseID )
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = -1;
            if ( clsInternationalLicenseDataAccess.FindInterNationalLicenseByInterNationalLicenseID( InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpiryDate, ref IsActive, ref CreatedByUserID ) )
            {
                return new clsInternationalLicense( InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
            }
            else
            {
                return null;
            }
        }
        public static clsInternationalLicense FindInternationalLicenseByApplicationID( int ApplicationID )
        {
            int InternationalLicenseID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = -1;
            if ( clsInternationalLicenseDataAccess.FindInternationalLicenseByApplicationID( ref InternationalLicenseID, ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpiryDate, ref IsActive, ref CreatedByUserID ) )
            {
                return new clsInternationalLicense( InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
            }
            else
            {
                return null;
            }
        }
        public static clsInternationalLicense FindInternationalLicenseByDriverID( int DriverID )
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = -1;
            if ( clsInternationalLicenseDataAccess.FindInternationalLicenseByDriverID( ref InternationalLicenseID, ref ApplicationID, DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpiryDate, ref IsActive, ref CreatedByUserID ) )
            {
                return new clsInternationalLicense( InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
            }
            else
            {
                return null;
            }
        }
        public static clsInternationalLicense FindInternationalLicenseByLocalLicenseID( int LocalLicenseID )
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = -1;
            if ( clsInternationalLicenseDataAccess.FindInternationalLicenseByLocalLicenseID( ref InternationalLicenseID, ref ApplicationID, ref DriverID, LocalLicenseID, ref IssueDate, ref ExpiryDate, ref IsActive, ref CreatedByUserID ) )
            {
                return new clsInternationalLicense( InternationalLicenseID, ApplicationID, DriverID, LocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
            }
            else
            {
                return null;
            }
        }
        public static bool isInternationalLicenseExists( int InternationalLicenseID )
        {
            return clsInternationalLicenseDataAccess.isInternationalLicenseExists( InternationalLicenseID );
        }
        public static int InternationalLicenseCount()
        {
            return clsInternationalLicenseDataAccess.InternationalLicensesCounts();
        }

        private bool AddNew()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewInternationalLicense( ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
            return ( this.InternationalLicenseID != -1 );
        }
        private bool Update()
        {
            return clsInternationalLicenseDataAccess.UpdateInternationalLicense( InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpiryDate, IsActive, CreatedByUserID );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( AddNew() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UPDATE:
                    return Update();
            }
            return false;
        }
    }
}

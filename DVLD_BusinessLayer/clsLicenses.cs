using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
using static System.Net.Mime.MediaTypeNames;
namespace DVLD_BusinessLayer
{
    public class clsLicenses
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        public enum enIssueReason
        {
            firstTime = 1,
            secondTime = 2,
            thirdTime = 3,
            fourthTime = 4,
            moreThanFourTimes = 5,
            Renew = 6,
            Replace = 7
        }
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte issueReason { get; set; }
        public int CreatedByUser { get; set; }
        enMode Mode = enMode.UPDATE;
        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpiryDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.issueReason = 0;
            this.CreatedByUser = -1;
            Mode = enMode.ADDNEW;
        }
        public clsLicenses( int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expiryDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUser )
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClassID = licenseClassID;
            this.IssueDate = issueDate;
            this.ExpiryDate = expiryDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.issueReason = issueReason;
            this.CreatedByUser = createdByUser;
            Mode = enMode.UPDATE;
        }
        public static clsLicenses FindLicenseByLicenseID( int licenseID )
        {
            int applicationID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expiryDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUser = 0;
            if ( clsLicensesDataAccess.FindLicenseByLicenseID( licenseID, ref driverID, ref applicationID, ref licenseClassID, ref issueDate, ref expiryDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUser ) )
            {
                return new clsLicenses( licenseID, applicationID, driverID, licenseClassID, issueDate, expiryDate, notes, paidFees, isActive, issueReason, createdByUser );
            }
            else
            {
                return null;
            }

        }
        public static clsLicenses FindLicenseByDriverID( int driverID )
        {
            int licenseID = -1;
            int applicationID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expiryDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUser = 0;
            if ( clsLicensesDataAccess.FindLicenseByDriverID( driverID, ref licenseID, ref applicationID, ref licenseClassID, ref issueDate, ref expiryDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUser ) )
            {
                return new clsLicenses( licenseID, applicationID, driverID, licenseClassID, issueDate, expiryDate, notes, paidFees, isActive, issueReason, createdByUser );
            }
            else
            {
                return null;
            }
        }
        public static clsLicenses FindLicenseByApplicationID( int applicationID )
        {
            int licenseID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expiryDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUser = 0;
            if ( clsLicensesDataAccess.FindLicenseByApplicationID( applicationID, ref licenseID, ref driverID, ref licenseClassID, ref issueDate, ref expiryDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUser ) )
            {
                return new clsLicenses( licenseID, applicationID, driverID, licenseClassID, issueDate, expiryDate, notes, paidFees, isActive, issueReason, createdByUser );
            }
            else
            {
                return null;
            }
        }
        public static clsLicenses FindLicenseClassByLicenseID( int licenseID )
        {
            int applicationID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expiryDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUser = 0;
            if ( clsLicensesDataAccess.FindLicenseByLicenseID( licenseClassID, ref applicationID, ref licenseID, ref driverID, ref issueDate, ref expiryDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUser ) )
            {
                return new clsLicenses( licenseID, applicationID, driverID, licenseClassID, issueDate, expiryDate, notes, paidFees, isActive, issueReason, createdByUser );
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicensesDataAccess.AddLicense( DriverID, ApplicationID, LicenseClassID, IssueDate, ExpiryDate, Notes, PaidFees, IsActive, issueReason, CreatedByUser );

            return ( this.LicenseID != -1 );
        }
        private bool _UpdateLicense()
        {
            return clsLicensesDataAccess.UpdateLicense( LicenseID, DriverID, ApplicationID, LicenseClassID, IssueDate, ExpiryDate, Notes, PaidFees, IsActive, issueReason, CreatedByUser );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddNewLicense() )
                    {
                        Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UPDATE:
                    return _UpdateLicense();
            }
            return false;
        }
        public static bool isLicenseExists( int licenseID )
        {
            return clsLicensesDataAccess.IsLicenseExists( licenseID );
        }
        public static bool isLicenseExists( int driverID, int applicationID, int licenseClass )
        {
            return clsLicensesDataAccess.IsLicenseExists( driverID, applicationID, licenseClass );
        }
        public static DataTable FindLicenseesByLicenseClassID( int licenseClassID )
        {
            return clsLicensesDataAccess.FindLicenseesByLicenseClassID( licenseClassID );
        }
        public static DataTable FindLicensesByDriverID( int driverID )
        {
            return clsLicensesDataAccess.FindLicensesByDriverID( driverID );
        }
        public static DataTable FindLicensesByApplicationID( int applicationID )
        {
            return clsLicensesDataAccess.FindLicensesByApplicationID( applicationID );
        }
        public static int CheckIfLicenseDateIsExpired( int driverID )
        {
            int id = -1;
            DataTable dt = clsLicensesDataAccess.FindLicensesByDriverID( driverID );
            if ( dt.Rows.Count > 0 )
            {
                foreach ( DataRow dr in dt.Rows )
                {
                    if ( ( ( DateTime ) dr[ "ExpirationDate" ] ) > DateTime.Now )
                    {
                        id = ( int ) dr[ "LicenseID" ];
                    }
                }

            }
            return id;
        }
        public static int CheckIfLicenseIsActive( int driverID )
        {
            int id = -1;
            DataTable dt = clsLicensesDataAccess.FindLicensesByDriverID( driverID );
            if ( dt.Rows.Count > 0 )
            {
                foreach ( DataRow dr in dt.Rows )
                {
                    if ( ( bool ) dr[ "IsActive" ] )
                    {
                        id = ( int ) dr[ "LicenseID" ];
                    }
                }

            }
            return id;
        }
    }
}
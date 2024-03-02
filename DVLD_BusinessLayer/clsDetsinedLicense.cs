using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsDetsinedLicense
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int detainID { get; set; }
        public int licenseID { get; set; }
        public DateTime detainDate { get; set; }
        public decimal fineFees { get; set; }
        public int createdByUserID { get; set; }
        public bool isRelaesed { get; set; }
        public DateTime releaseDate { get; set; }
        public int releasedByUserID { get; set; }
        public int releaseApplicationID { get; set; }
        enMode Mode = enMode.UPDATE;
        public clsDetsinedLicense()
        {
            detainID = -1;
            licenseID = -1;
            detainDate = DateTime.Now;
            fineFees = 0;
            createdByUserID = -1;
            isRelaesed = false;
            releaseDate = DateTime.Now;
            releasedByUserID = -1;
            releaseApplicationID = -1;
            Mode = enMode.ADDNEW;
        }
        public clsDetsinedLicense( int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isRelaesed, DateTime releaseDate, int releasedByUserID, int releaseApplicationID )
        {
            this.detainID = detainID;
            this.licenseID = licenseID;
            this.detainDate = detainDate;
            this.fineFees = fineFees;
            this.createdByUserID = createdByUserID;
            this.isRelaesed = isRelaesed;
            this.releaseDate = releaseDate;
            this.releasedByUserID = releasedByUserID;
            this.releaseApplicationID = releaseApplicationID;
        }
        public static clsDetsinedLicense FindDetainLicenseByDetainID( int detainID )
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releasedDate = DateTime.Now;
            int releasedByUserId = -1;
            int releaseApplicationID = -1;
            if ( clsDetainLicenseDataAccess.FindDetainLicenseByDetainID( detainID, ref licenseID, ref detainDate, ref fineFees, ref createdByUserID, ref isReleased, ref releasedDate, ref releasedByUserId, ref releaseApplicationID ) )
            {
                return new clsDetsinedLicense( detainID, licenseID, detainDate, fineFees, createdByUserID, isReleased, releasedDate, releasedByUserId, releaseApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsDetsinedLicense FindDetainLicenseByLicenseID( int licenseID )
        {
            int detainID = -1;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releasedDate = DateTime.Now;
            int releasedByUserId = -1;
            int releaseApplicationID = -1;
            if ( clsDetainLicenseDataAccess.FindDetainLicenseByLicenseID( licenseID, ref detainID, ref detainDate, ref fineFees, ref createdByUserID, ref isReleased, ref releasedDate, ref releasedByUserId, ref releaseApplicationID ) )
            {
                return new clsDetsinedLicense( detainID, licenseID, detainDate, fineFees, createdByUserID, isReleased, releasedDate, releasedByUserId, releaseApplicationID );
            }
            else
            {
                return null;
            }
        }
        private bool _AddNew()
        {
            this.detainID = clsDetainLicenseDataAccess.AddNewDetainLicense( licenseID, detainDate, fineFees, createdByUserID, isRelaesed, releaseDate, releasedByUserID, releaseApplicationID );
            return ( this.detainID != -1 );
        }
        private bool _Update()
        {
            return clsDetainLicenseDataAccess.UpdateDetainLicense( detainID, licenseID, detainDate, fineFees, createdByUserID, isRelaesed, releaseDate, releasedByUserID, releaseApplicationID );
        }
        public static bool DeleteDetainLicense( int detainID )
        {
            return clsDetainLicenseDataAccess.DeleteDetainLicense( detainID );
        }
        public static DataTable GetAllDetainLicenses()
        {
            return clsDetainLicenseDataAccess.GetAllDetainedLicenses();
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddNew() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UPDATE:
                    return _Update();
            }
            return false;
        }
    }
}

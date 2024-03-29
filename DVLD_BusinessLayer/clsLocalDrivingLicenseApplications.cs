﻿using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        public int localDrivingLicenseApplicationID { get; set; }
        public int licenseClassID { get; set; }
        public int applicationID { get; set; }
        public enMode Mode { get; set; }
        public clsLocalDrivingLicenseApplications()
        {
            this.localDrivingLicenseApplicationID = -1;
            this.licenseClassID = -1;
            this.applicationID = -1;
            this.Mode = enMode.ADDNEW;
        }
        public clsLocalDrivingLicenseApplications( int localDrivingLicenseApplicationID, int licenseClassID, int applicationID )
        {
            this.localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.licenseClassID = licenseClassID;
            this.applicationID = applicationID;
            this.Mode = enMode.UPDATE;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicesnseApllications();
        }
        public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationByID( int LocalDrivingLicenseApplicationID )
        {
            int licenseClassID = -1;
            int applicationID = -1;
            if ( clsLocalDrivingLicenseApplicationsDataAccess.FindLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID( LocalDrivingLicenseApplicationID, ref licenseClassID, ref applicationID ) )
            {
                return new clsLocalDrivingLicenseApplications( LocalDrivingLicenseApplicationID, licenseClassID, applicationID );
            }
            else
            {
                return null;
            }
        }
        public clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationByLicenseClassID( int licenceClassID )
        {
            int localDrivingApplicationID = -1;
            int applicationID = -1;
            if ( clsLocalDrivingLicenseApplicationsDataAccess.FindLocalDrivingLicenseApplicationByLicenseClassID( ref localDrivingApplicationID, licenceClassID, ref applicationID ) )
            {
                return new clsLocalDrivingLicenseApplications( localDrivingLicenseApplicationID, licenseClassID, applicationID );
            }
            else
            {
                return null;
            }
        }
        // find local driving license application by application id
        public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationByApplicationID( int applicationID )
        {
            int localDrivingLicenseApplicationID = -1;
            int licenseClassID = -1;
            if ( clsLocalDrivingLicenseApplicationsDataAccess.FindLocalDrivingLicenseApplicationByApplicationID( applicationID, ref localDrivingLicenseApplicationID, ref licenseClassID ) )
            {
                return new clsLocalDrivingLicenseApplications( localDrivingLicenseApplicationID, licenseClassID, applicationID );
            }
            else
            {
                return null;
            }
        }

        public bool AddNewLocalDrivingLicenseApplication()
        {
            this.applicationID = clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplication( this.licenseClassID, this.applicationID );
            return ( this.applicationID != -1 );
        }
        public bool UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.UpdateLocalDrivingLicenseApplication( this.localDrivingLicenseApplicationID, this.licenseClassID, this.applicationID );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( AddNewLocalDrivingLicenseApplication() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UPDATE:
                    return UpdateLocalDrivingLicenseApplication();
                default:
                    return false;
            }
        }
    }
}

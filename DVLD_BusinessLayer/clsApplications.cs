using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLayer
{
    public class clsApplications
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int applicationID { get; set; }
        public int applicationPersonID { get; set; }
        public DateTime applicationDate { get; set; }
        public int applicationTypeID { get; set; }
        public int applicationStatus { get; set; }
        public DateTime lastStatusDate { get; set; }
        public decimal paidFees { get; set; }
        public int createdByUserID { get; set; }
        public enMode Mode = enMode.ADDNEW;
        public clsApplications()
        {
            this.applicationID = -1;
            this.applicationPersonID = -1;
            this.applicationDate = DateTime.MinValue;
            this.applicationTypeID = -1;
            this.applicationStatus = -1;
            this.lastStatusDate = DateTime.Now;
            this.paidFees = 0;
            this.createdByUserID = -1;
            Mode = enMode.ADDNEW;
        }
        public clsApplications( int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID )
        {
            this.applicationID = applicationID;
            this.applicationPersonID = applicationPersonID;
            this.applicationDate = applicationDate;
            this.applicationTypeID = applicationTypeID;
            this.applicationStatus = applicationStatus;
            this.lastStatusDate = lastStatusDate;
            this.paidFees = paidFees;
            this.createdByUserID = createdByUserID;
            Mode = enMode.UPDATE;
        }
        //find application by application id
        public static clsApplications FindApplicationByID( int applicationID )
        {
            int applicationPersonID = -1;
            DateTime applicationDate = DateTime.MinValue;
            int applicationTypeID = -1;
            int applicationStatus = -1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            if ( clsApplicationsDataAccess.FindApplicationByApplicationID( applicationID, ref applicationPersonID, ref applicationDate, ref applicationTypeID, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID ) )
            {
                return new clsApplications( applicationID, applicationPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID );
            }
            else
            {
                return null;
            }
        }
        //find application by person id
        public static clsApplications FindApplicationByPersonID( int applicationPersonID )
        {
            int applicationID = -1;
            DateTime applicationDate = DateTime.MinValue;
            int applicationTypeID = -1;
            int applicationStatus = -1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            if ( clsApplicationsDataAccess.FindApplicationByPersonID( applicationPersonID, ref applicationID, ref applicationDate, ref applicationTypeID, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID ) )
            {
                return new clsApplications( applicationID, applicationPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID );
            }
            else
            {
                return null;
            }
        }
        //find application by application type id
        public static clsApplications FindApplicationByApplicationTypeID( int applicationTypeID )
        {
            int applicationID = -1;
            int applicationPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationStatus = -1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            if ( clsApplicationsDataAccess.FindApplicationByApplicationTypeID( applicationTypeID, ref applicationID, ref applicationPersonID, ref applicationDate, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID ) )
            {
                return new clsApplications( applicationID, applicationPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID );
            }
            else
            {
                return null;
            }
        }
        //get all applications
        public static System.Data.DataTable GetAllApplications()
        {
            return clsApplicationsDataAccess.GetAllApplications();
        }
        //add new application 
        private bool _AddNewApplication()
        {
            this.applicationID = clsApplicationsDataAccess.AddNewApplication( this.applicationPersonID, this.applicationDate, this.applicationTypeID, this.applicationStatus, this.lastStatusDate, this.paidFees, this.createdByUserID );
            return ( this.applicationID != -1 );
        }
        //update application
        private bool _UpdateApplication()
        {
            return clsApplicationsDataAccess.UpdateApplication( this.applicationID, this.applicationPersonID, this.applicationDate, this.applicationTypeID, this.applicationStatus, this.lastStatusDate, this.paidFees, this.createdByUserID );
        }
        //delete application 
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddNewApplication() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UPDATE:
                    return _UpdateApplication();
            }
            return false;
        }
    }
}

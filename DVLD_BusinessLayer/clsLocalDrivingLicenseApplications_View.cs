using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplications_View
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTestCount { get; set; }
        public string Status { get; set; }
        enMode Mode = enMode.UPDATE;

        clsLocalDrivingLicenseApplications_View()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ClassName = string.Empty;
            this.NationalNo = string.Empty;
            this.FullName = string.Empty;
            this.ApplicationDate = DateTime.MinValue;
            this.PassedTestCount = -1;
            this.Status = string.Empty;
        }
        clsLocalDrivingLicenseApplications_View( int localDrivingLicenseApplicationID, string className, string nationalNo, string fullName, DateTime applicationDate, int passedTestCount, string status )
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ClassName = className;
            NationalNo = nationalNo;
            FullName = fullName;
            ApplicationDate = applicationDate;
            PassedTestCount = passedTestCount;
            Status = status;
        }
        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplications_ViewDataAccess.GetAllLocalDrivingLicenseApplications();
        }
        public static clsLocalDrivingLicenseApplications_View FindLocalDrivingLicenseApplicationID( int localDrivingLicenseApplicationID )
        {
            string className = string.Empty;
            string nationalNO = string.Empty;
            string fullName = string.Empty;
            DateTime applicationDate = DateTime.MinValue;
            int passedTest = -1;
            string status = string.Empty;
            if ( clsLocalDrivingLicenseApplications_ViewDataAccess.FindLocalDrivingLicenseApplicationByID( localDrivingLicenseApplicationID, ref className, ref nationalNO, ref fullName, ref applicationDate, ref passedTest, ref status ) )
            {
                return new clsLocalDrivingLicenseApplications_View( localDrivingLicenseApplicationID, className, nationalNO, fullName, applicationDate, passedTest, status );
            }
            else
            {
                return null;
            }
        }
        public static clsLocalDrivingLicenseApplications_View FindLocalDrivingLicenseApplicationByNationalID( string nationalNO )
        {
            int localDrivingLicenseApplicationID = -1;
            string className = string.Empty;
            string fullName = string.Empty;
            DateTime applicationDate = DateTime.MinValue;
            int passedTest = -1;
            string status = string.Empty;
            if ( clsLocalDrivingLicenseApplications_ViewDataAccess.FindLocalDrivingLicenseApplicationByNationalNO( ref localDrivingLicenseApplicationID, ref className, nationalNO, ref fullName, ref applicationDate, ref passedTest, ref status ) )
            {
                return new clsLocalDrivingLicenseApplications_View( localDrivingLicenseApplicationID, className, nationalNO, fullName, applicationDate, passedTest, status );
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplications_ViewDataAccess.AddNewLocalDrivingLicenseApplication( this.ClassName, this.NationalNo, this.FullName, this.ApplicationDate, this.PassedTestCount, this.Status );
            return ( this.LocalDrivingLicenseApplicationID != -1 );
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplications_ViewDataAccess.UpdateLocalDrivingLicenseApplication( this.LocalDrivingLicenseApplicationID, this.ClassName, this.NationalNo, this.FullName, this.ApplicationDate, this.PassedTestCount, this.Status );
        }
        public bool IsLocalDrivingLicenseApplicationID( int localApplicationID )
        {
            return clsLocalDrivingLicenseApplications_ViewDataAccess.IsLocalDrivingLicenseApplicationExist( localApplicationID );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddNewLocalDrivingLicenseApplication() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UPDATE:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return false;
        }
    }
}

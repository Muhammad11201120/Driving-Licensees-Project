using DVLD_DataAccessLayer;
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

        public DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicesnseApllications();
        }
        public clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationByID( int LocalDrivingLicenseApplicationID )
        {
            int licenseClassID = -1;
            int applicationID = -1;
            if ( clsLocalDrivingLicenseApplicationsDataAccess.FindLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID( localDrivingLicenseApplicationID, ref licenseClassID, ref applicationID ) )
            {
                return new clsLocalDrivingLicenseApplications( localDrivingLicenseApplicationID, licenseClassID, applicationID );
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
    }
}

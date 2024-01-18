using System;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplications_View
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string ClassName { get; set; }
        public int NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTestCount { get; set; }
        public string Status { get; set; }

        clsLocalDrivingLicenseApplications_View()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ClassName = string.Empty;
            this.NationalNo = -1;
            this.FullName = string.Empty;
            this.ApplicationDate = DateTime.MinValue;
            this.PassedTestCount = -1;
            this.Status = string.Empty;
        }
        clsLocalDrivingLicenseApplications_View( int localDrivingLicenseApplicationID, string className, int nationalNo, string fullName, DateTime applicationDate, int passedTestCount, string status )
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ClassName = className;
            NationalNo = nationalNo;
            FullName = fullName;
            ApplicationDate = applicationDate;
            PassedTestCount = passedTestCount;
            Status = status;
        }
    }
}

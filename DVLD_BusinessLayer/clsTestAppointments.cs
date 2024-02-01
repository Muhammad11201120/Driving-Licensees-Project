using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointments
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        int testAppointmentID { get; set; }
        int testTypeID { get; set; }
        int LocalDrivingLicenseApplicationID { get; set; }
        DateTime testAppointmentDate { get; set; }
        decimal paidFees { get; set; }
        int createdByUserID { get; set; }
        bool isLocked { get; set; }
        int RetakeTestApplicationID { get; set; }
        enMode Mode = enMode.UPDATE;
        public clsTestAppointments()
        {
            this.testAppointmentID = -1;
            this.testTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.testAppointmentDate = DateTime.Now;
            this.paidFees = 0;
            this.createdByUserID = -1;
            this.isLocked = false;
            this.RetakeTestApplicationID = -1;
        }
        public clsTestAppointments( int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime testAppointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID )
        {
            this.testAppointmentID = testAppointmentID;
            this.testTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.testAppointmentDate = testAppointmentDate;
            this.paidFees = paidFees;
            this.createdByUserID = createdByUserID;
            this.isLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
        }
        public static clsTestAppointments FindTestAppointmentByTestAppointmentID( int testAppointmentID )
        {
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppoinmentByTestAppoinmentID( testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID, ref testAppointmentDate, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByTestTypeID( int testTypeID )
        {
            int testAppointmentID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByTestTypeID( testTypeID, ref testAppointmentID, ref localDrivingLicenseApplicationID, ref testAppointmentDate, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByLocalDrivingLicenseApplicationID( int localDrivingLicenseApplicationID )
        {
            int testAppointmentID = -1;
            int testTypeID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByLocalDrivingLicenseApplicationID( localDrivingLicenseApplicationID, ref testAppointmentID, ref testTypeID, ref testAppointmentDate, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByTestAppointmentDate( DateTime testAppointmentDate )
        {
            int testAppointmentID = -1;
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            decimal paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByTestAppointmentDate( testAppointmentDate, ref testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByPaidFees( decimal paidFees )
        {
            int testAppointmentID = -1;
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByPaidFees( paidFees, ref testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID, ref testAppointmentDate, ref createdByUserID, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByCreatedByUserID( int createdByUserID )
        {
            int testAppointmentID = -1;
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            decimal paidFees = 0;
            bool isLocked = false;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByCreatedByUserID( createdByUserID, ref testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID, ref testAppointmentDate, ref paidFees, ref isLocked, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static clsTestAppointments FindTestAppointmentByIsLocked( bool isLocked )
        {
            int testAppointmentID = -1;
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime testAppointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            int retakeTestApplicationID = -1;
            if ( clsTestAppointmentsDataAccess.FindTestAppointmentByIsLocked( isLocked, ref testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID, ref testAppointmentDate, ref paidFees, ref createdByUserID, ref retakeTestApplicationID ) )
            {
                return new clsTestAppointments( testAppointmentID, testTypeID, localDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID );
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppoinments();
        }
        private bool _AddTestAppointment()
        {
            return clsTestAppointmentsDataAccess.AddTestAppoinment( testTypeID, LocalDrivingLicenseApplicationID, testAppointmentDate, paidFees, createdByUserID, isLocked, this.RetakeTestApplicationID );
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppoinment( this.testAppointmentID, this.testTypeID, this.LocalDrivingLicenseApplicationID, this.testAppointmentDate, this.paidFees, this.createdByUserID, this.isLocked, this.RetakeTestApplicationID );
        }
        public bool DeleteTestAppointment()
        {
            return clsTestAppointmentsDataAccess.DeleteTestAppoinment( this.testAppointmentID );
        }

        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddTestAppointment() )
                    {
                        Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UPDATE:
                    return _UpdateTestAppointment();
            }
            return false;
        }
    }
}

﻿using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTests
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        public int testID { get; set; }
        public int testAppointmentID { get; set; }
        public bool testResult { get; set; }
        public string notes { get; set; }
        public int createdByUserID { get; set; }
        enMode Mode = enMode.UPDATE;
        public clsTests()
        {
            this.testID = -1;
            this.testAppointmentID = -1;
            this.testResult = false;
            this.notes = "";
            this.createdByUserID = -1;
            Mode = enMode.ADDNEW;
        }
        public clsTests( int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID )
        {
            this.testID = testID;
            this.testAppointmentID = testAppointmentID;
            this.testResult = testResult;
            this.notes = notes;
            this.createdByUserID = createdByUserID;
            Mode = enMode.UPDATE;
        }
        public static clsTests FindTestByTestID( int testID )
        {
            string notes = "";
            int createdByUserID = -1;
            bool testResult = false;
            int testAppointmentID = -1;
            if ( clsTestsDatatAccess.FindTestByTestID( testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID ) )
            {
                return new clsTests( testID, testAppointmentID, testResult, notes, createdByUserID );
            }
            else
                return null;
        }
        public static clsTests FindTestByTestAppointmentID( int testAppointmentID )
        {
            string notes = "";
            int createdByUserID = -1;
            bool testResult = false;
            int testID = -1;
            if ( clsTestsDatatAccess.FindTestByTestAppointmentID( testAppointmentID, ref testID, ref testResult, ref notes, ref createdByUserID ) )
            {
                return new clsTests( testID, testAppointmentID, testResult, notes, createdByUserID );
            }
            else
                return null;
        }
        public static clsTests FindTestByTestResult( bool testResult )
        {
            string notes = "";
            int createdByUserID = -1;
            int testAppointmentID = -1;
            int testID = -1;
            if ( clsTestsDatatAccess.FindTestByTestResult( testResult, ref testID, ref testAppointmentID, ref notes, ref createdByUserID ) )
            {
                return new clsTests( testID, testAppointmentID, testResult, notes, createdByUserID );
            }
            else
                return null;
        }
        private bool _AdNewTest()
        {
            this.testID = clsTestsDatatAccess.AddNewTest( this.testAppointmentID, this.testResult, this.notes, this.createdByUserID );
            return ( this.testID != -1 );
        }
        private bool _UpdateTest()
        {
            return clsTestsDatatAccess.UpdateTest( this.testID, this.testAppointmentID, this.testResult, this.notes, this.createdByUserID );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AdNewTest() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UPDATE:
                    return _UpdateTest();
            }
            return false;
        }
        public static bool DoesAttendTestType( int testAppointmentID, int testTypeID )
        {
            return clsTestsDatatAccess.DoesAttendTestType( testAppointmentID, testTypeID );
        }
        public static bool DoesPassTestType( int testAppointmentID, int testTypeID )
        {
            return clsTestsDatatAccess.DoesPassTestType( testAppointmentID, testTypeID );
        }
    }
}

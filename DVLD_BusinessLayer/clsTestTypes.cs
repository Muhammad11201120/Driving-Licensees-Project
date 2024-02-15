using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestTypes
    {
        public enum enTestTypes
        {
            VisionTest = 1,
            WrittenTest = 2,
            DrivingTest = 3
        }
        public int testTypeID { get; set; }
        public string testTypeTitle { get; set; }
        public string testTypeDescription { get; set; }
        public decimal testFees { get; set; }
        clsTestTypes()
        {
            this.testTypeID = -1;
            this.testTypeTitle = "";
            this.testTypeDescription = "";
            this.testFees = 0;
        }
        public clsTestTypes( int testTypeID, string testTypeTitle, string testTypeDescription, decimal testFees )
        {
            this.testTypeID = testTypeID;
            this.testTypeTitle = testTypeTitle;
            this.testTypeDescription = testTypeDescription;
            this.testFees = testFees;
        }
        public static clsTestTypes FindTestTypeByTestTypeID( int testTyeID )
        {
            string testTypeTitle = "";
            string testTypeDescription = "";
            decimal testFees = 0;
            if ( clsTestTypesDataAccess.FindTestTypeByTestTypeID( testTyeID, ref testTypeTitle, ref testTypeDescription, ref testFees ) )
            {
                return new clsTestTypes( testTyeID, testTypeTitle, testTypeDescription, testFees );
            }
            else
            {
                return null;
            }
        }
        public static clsTestTypes FindTestTypeByTestTypeTitle( string testTypeTitle )
        {
            int testTypeID = -1;
            string testTypeDescription = "";
            decimal testFees = 0;
            if ( clsTestTypesDataAccess.FindTestTypeByTestTypeTitle( testTypeTitle, ref testTypeID, ref testTypeDescription, ref testFees ) )
            {
                return new clsTestTypes( testTypeID, testTypeTitle, testTypeDescription, testFees );
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }
    }
}

using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicensesClasses
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidationLength { get; set; }
        public decimal ClassFees { get; set; }
        public enMode Mode = enMode.UPDATE;
        public clsLicensesClasses()
        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge = 0;
            this.DefaultValidationLength = 0;
            this.ClassFees = 0;
            this.Mode = enMode.ADDNEW;
        }
        public clsLicensesClasses( int liceneseClassID, string className, string classDescription, byte minimumAllowedAge, byte defaultValidationLength, decimal classFees )
        {
            this.LicenseClassID = liceneseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidationLength = defaultValidationLength;
            this.ClassFees = classFees;
            this.Mode = enMode.UPDATE;
        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicensesClassesDataAccess.GetAllClasses();
        }
        public static clsLicensesClasses FindClassByID( int licenseClassID )
        {
            string className = string.Empty;
            string classDescription = string.Empty;
            byte minimumAllowedAge = 0;
            byte defaultValidationLength = 0;
            decimal classFees = 0;
            if ( clsLicensesClassesDataAccess.FindClassByID( licenseClassID, ref className, ref classDescription, ref minimumAllowedAge, ref defaultValidationLength, ref classFees ) )
            {
                return new clsLicensesClasses( licenseClassID, className, classDescription, minimumAllowedAge, defaultValidationLength, classFees );
            }
            else
            {
                return null;
            }
        }
        public static clsLicensesClasses FindClassByName( string className )
        {
            int licenseClassID = -1;
            string classDescription = string.Empty;
            byte minumumAllowAge = 0;
            byte defaultValidationLength = 0;
            decimal classFees = -1;
            if ( clsLicensesClassesDataAccess.FindClassByName( ref licenseClassID, className, ref classDescription, ref minumumAllowAge, ref defaultValidationLength, ref classFees ) )
            {
                return new clsLicensesClasses( licenseClassID, className, classDescription, minumumAllowAge, defaultValidationLength, classFees );
            }
            else
            {
                return null;
            }
        }
        //add new licenseClass
        private bool _AddNewLicenseClass()
        {
            LicenseClassID = clsLicensesClassesDataAccess.AddNewLicenseClass( ClassName, ClassDescription, MinimumAllowedAge, DefaultValidationLength, ClassFees );
            return ( LicenseClassID != -1 );
        }
        // update LicenseClass
        private bool _UpdateLicenseClass()
        {
            return clsLicensesClassesDataAccess.UpdateLicenseClass( LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidationLength, ClassFees );
        }
        //Save
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddNewLicenseClass() )
                    {
                        this.Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UPDATE:
                    return _UpdateLicenseClass();
            }
            return false;
        }
        public static bool IsClassExist( int licenseClassID )
        {
            return clsLicensesClassesDataAccess.IsClassExist( licenseClassID );
        }
        public static bool IsClassExist( string className )
        {
            return clsLicensesClassesDataAccess.IsClassExist( className );
        }
        public static bool DeleteClass( int licenseClassID )
        {
            return clsLicensesClassesDataAccess.DeleteClass( licenseClassID );
        }
    }
}

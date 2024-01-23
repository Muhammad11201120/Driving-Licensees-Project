using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicensesClasses
    {
        enum _enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int DefaultValidationLength { get; set; }
        public decimal ClassFees { get; set; }
        _enMode Mode = _enMode.UPDATE;
        public clsLicensesClasses()
        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.DefaultValidationLength = 0;
            this.ClassFees = 0;
            Mode = _enMode.ADDNEW;
        }
        public clsLicensesClasses( int liceneseClassID, string className, string ClassDescription, int defaultValidationLength, decimal classFees )
        {
            this.LicenseClassID = liceneseClassID;
            this.ClassName = className;
            this.ClassDescription = ClassDescription;
            this.DefaultValidationLength = defaultValidationLength;
            this.ClassFees = classFees;
        }
        public static DataTable GetAllLicenseClases()
        {
            return clsLicensesClassesDataAccess.GetAllClasses();
        }
        public static clsLicensesClasses FindClassByID( int licenseClassID )
        {
            string className = string.Empty;
            string classDescription = string.Empty;
            int defaultValidationLength = -1;
            decimal classFees = -1;
            if ( clsLicensesClassesDataAccess.FindClassByID( licenseClassID, ref className, ref classDescription, ref defaultValidationLength, ref classFees ) )
            {
                return new clsLicensesClasses( licenseClassID, className, classDescription, defaultValidationLength, classFees );
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
            int defaultValidationLength = -1;
            decimal classFees = -1;
            if ( clsLicensesClassesDataAccess.FindClassByName( ref licenseClassID, className, ref classDescription, ref defaultValidationLength, ref classFees ) )
            {
                return new clsLicensesClasses( licenseClassID, className, classDescription, defaultValidationLength, classFees );
            }
            else
            {
                return null;
            }
        }
        private bool AddNewClass()
        {
            this.LicenseClassID = clsLicensesClassesDataAccess.AddNewClass( this.ClassName, this.ClassDescription, this.DefaultValidationLength, this.ClassFees );
            if ( this.LicenseClassID > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool UpdateClass()
        {
            return clsLicensesClassesDataAccess.UpdateClass( this.LicenseClassID, this.ClassName, this.ClassDescription, this.DefaultValidationLength, this.ClassFees );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case _enMode.ADDNEW:
                    if ( AddNewClass() )
                    {
                        this.Mode = _enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case _enMode.UPDATE:
                    return UpdateClass();
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

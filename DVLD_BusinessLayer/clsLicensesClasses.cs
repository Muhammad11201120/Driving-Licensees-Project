using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicensesClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int DefaultValidationLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicensesClasses( int liceneseClassID, string className, string ClassDescription, int defaultValidationLength, decimal classFees )
        {
            this.LicenseClassID = liceneseClassID;
            this.ClassName = className;
            this.ClassDescription = ClassDescription;
            this.DefaultValidationLength = defaultValidationLength;
            this.ClassFees = classFees;
        }
        public static DataTable GetAllApplicationClases()
        {
            return clsLicensesClassesDataAccess.GetAllClasses();
        }
    }
}

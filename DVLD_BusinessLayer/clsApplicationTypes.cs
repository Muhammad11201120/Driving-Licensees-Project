using DVLD_DataAccessLayer;
using System.Data;
namespace DVLD_BusinessLayer
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationTypes( int applicationTypeID, string applicationTypeTitle, decimal applicationFees )
        {
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationFees = applicationFees;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }
        public static clsApplicationTypes FindApplicationTypeByID( int id )
        {
            string applicationTitle = string.Empty;
            decimal applicationFees = 0;
            if ( clsApplicationTypesDataAccess.FindApplicationTypeByID( id, ref applicationTitle, ref applicationFees ) )
            {
                return new clsApplicationTypes( id, applicationTitle, applicationFees );
            }
            else
            {
                return null;
            }
        }
        public bool UpdateApplicationType( int id )
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType( id, this.ApplicationTypeTitle, this.ApplicationFees );
        }


    }
}

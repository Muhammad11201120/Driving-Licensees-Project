using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
namespace DVLD_BusinessLayer
{
    public class clsDrivers
    {
        private enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        enMode Mode = enMode.UPDATE;
        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.ADDNEW;
        }
        public clsDrivers( int driverID, int personID, int createdByUserID, DateTime createdDate )
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;

        }
        public static DataTable getDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }
        public static clsDrivers FindDriverByDriverID( int driverID )
        {
            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.Now;
            if ( clsDriversDataAccess.FindDriverByDriverID( driverID, ref personID, ref createdByUserID, ref createdDate ) )
            {
                return new clsDrivers( driverID, personID, createdByUserID, createdDate );
            }
            else
            {
                return null;
            }
        }
        public static clsDrivers FindDriverByPersonID( int personID )
        {
            int driverID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.Now;
            if ( clsDriversDataAccess.FindDriverByPersonID( personID, ref driverID, ref createdByUserID, ref createdDate ) )
            {
                return new clsDrivers( driverID, personID, createdByUserID, createdDate );
            }
            else
            {
                return null;
            }
        }
        public static bool DeleteDriver( int driverID )
        {
            return clsDriversDataAccess.DeleteDriver( driverID );
        }
        public static bool isDriverExists( int driverID )
        {
            return clsDriversDataAccess.isDriverExists( driverID );
        }
        public static int TottalDrivers()
        {
            return clsDriversDataAccess.TotalDrivers();
        }

        private bool _AddDriver()
        {
            this.DriverID = clsDriversDataAccess.AddDriver( PersonID, CreatedByUserID, CreatedDate );
            return ( DriverID != -1 );
        }
        private bool _UpdateDriver()
        {
            return clsDriversDataAccess.UpdateDriver( DriverID, PersonID, CreatedByUserID, CreatedDate );
        }
        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.ADDNEW:
                    if ( _AddDriver() )
                    {
                        Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UPDATE:
                    return _UpdateDriver();
            }
            return false;
        }
    }
}

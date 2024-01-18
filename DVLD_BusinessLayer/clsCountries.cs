using System.Data;

namespace DVLD_DataAccessLayer
{
    public class clsCountries
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }
        private clsCountries( int countryID, string countryName )
        {
            this.CountryID = countryID;
            this.CountryName = countryName;

        }
        public clsCountries()
        {
            this.CountryID = -1;
            this.CountryName = "";

        }
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccsess.GetAllCountries();
        }
        public static clsCountries FindContry( int CountryID )
        {
            string CountryName = "";
            if ( clsCountriesDataAccsess.FindCountry( CountryID, ref CountryName ) )
            {
                return new clsCountries( CountryID, CountryName );
            }
            else
            {
                return null;
            }
        }
        public static clsCountries FindContry( string CountryName )
        {
            int CountryID = -1;
            if ( clsCountriesDataAccsess.FindCountryByName( ref CountryID, CountryName ) )
            {
                return new clsCountries( CountryID, CountryName );
            }
            else
            {
                return null;
            }
        }
    }
}

﻿using System;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static bool FindApplicationByApplicationID( int applicationID, ref int applicationPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref byte applicationStatus, ref DateTime laststatusDate, ref decimal paidFees, ref int createdByUserId )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT top 1 * FROM Applications WHERE ApplicationID = @apllicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@apllicationID", applicationID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    applicationPersonID = ( int ) reader[ "ApplicantPersonID" ];
                    applicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    applicationTypeID = ( int ) reader[ "ApplicationTypeID" ];
                    applicationStatus = ( byte ) reader[ "ApplicationStatus" ];
                    laststatusDate = ( DateTime ) reader[ "LastStatusDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    createdByUserId = ( int ) reader[ "CreatedByUserID" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        // find application by person id
        public static bool FindApplicationByPersonID( int personID, ref int applicationID, ref DateTime applicationDate, ref int applicationTypeID, ref byte applicationStatus, ref DateTime laststatusDate, ref decimal paidFees, ref int createdByUserId )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Applications WHERE ApplicantPersonID = @personID ORDER BY ApplicantPersonID DESC";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@personID", personID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    applicationID = ( int ) reader[ "ApplicationID" ];
                    applicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    applicationTypeID = ( int ) reader[ "ApplicationTypeID" ];
                    applicationStatus = ( byte ) reader[ "ApplicationStatus" ];
                    laststatusDate = ( DateTime ) reader[ "LastStatusDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    createdByUserId = ( int ) reader[ "CreatedByUserID" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        // find application by application type id
        public static bool FindApplicationByApplicationTypeID( int applicationTypeID, ref int applicationID, ref int applicationPersonID, ref DateTime applicationDate, ref byte applicationStatus, ref DateTime laststatusDate, ref decimal paidFees, ref int createdByUserId )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Applications WHERE ApplicationTypeID = @applicationTypeID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationTypeID", applicationTypeID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    applicationTypeID = ( int ) reader[ "ApplicationTypeID" ];
                    applicationID = ( int ) reader[ "ApplicationID" ];
                    applicationPersonID = ( int ) reader[ "ApplicantPersonID" ];
                    applicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    applicationStatus = ( byte ) reader[ "ApplicationStatus" ];
                    laststatusDate = ( DateTime ) reader[ "LastStatusDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                    createdByUserId = ( int ) reader[ "CreatedByUserID" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        // Find Application ByCreatedByUserID
        public static bool FindApplicationByCreatedByUserID( int createdByUserID, ref int applicationID, ref int applicationPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref byte applicationStatus, ref DateTime laststatusDate, ref decimal paidFees )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT TOP 1 * FROM Applications WHERE CreatedByUserID = @createdByUserID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserID );

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read() )
                {
                    isFound = true;
                    applicationID = ( int ) reader[ "ApplicationID" ];
                    applicationPersonID = ( int ) reader[ "ApplicantPersonID" ];
                    applicationDate = ( DateTime ) reader[ "ApplicationDate" ];
                    applicationTypeID = ( int ) reader[ "ApplicationTypeID" ];
                    applicationStatus = ( byte ) reader[ "ApplicationStatus" ];
                    laststatusDate = ( DateTime ) reader[ "LastStatusDate" ];
                    paidFees = ( decimal ) reader[ "PaidFees" ];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                // isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        // get all applications
        public static System.Data.DataTable GetAllApplications()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Applications";
            SqlCommand cmd = new SqlCommand( query, connection );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load( reader );
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        //Get All Applications By Application ID
        public static System.Data.DataTable GetAllApplicationsByApplicationID( int applicationID )
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Applications WHERE ApplicationID = @applicationID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load( reader );
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        //Get All Applications By Application Person ID
        public static System.Data.DataTable GetAllApplicationsByApplicationPersonID( int applicationPersonID )
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Applications WHERE ApplicantPersonID = @applicationPersonID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationPersonID", applicationPersonID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load( reader );
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        //Get All Applications By Application Type ID
        public static System.Data.DataTable GetAllApplicationsByApplicationTypeID( int applicationTypeID )
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT * FROM Applications WHERE ApplicationTypeID = @applicationTypeID";
            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationTypeID", applicationTypeID );
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load( reader );
                reader.Close();
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int AddNewApplication( int applicationPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus, DateTime laststatusDate, decimal paidFees, int createdByUserId )
        {
            // this function returns int so we will store it in this variable
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"INSERT INTO Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) 
                            VALUES 
                            (@applicationPersonID,@applicationDate,@applicationTypeID,@applicationStatus,@laststatusDate,@paidFees,@createdByUserId);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationPersonID", applicationPersonID );
            cmd.Parameters.AddWithValue( "@applicationDate", applicationDate );
            cmd.Parameters.AddWithValue( "@applicationTypeID", applicationTypeID );
            cmd.Parameters.AddWithValue( "@applicationStatus", applicationStatus );
            cmd.Parameters.AddWithValue( "@laststatusDate", laststatusDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@createdByUserId", createdByUserId );

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int insertedID ) )
                {
                    ApplicationID = insertedID;
                }
            }
            catch ( System.Exception ex )
            {

                //do nothing
            }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static bool UpdateApplication( int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus, DateTime laststatusDate, decimal paidFees, int createdByUserId )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = @"UPDATE Applications SET 
                            ApplicantPersonID = @applicantPersonID,
                            ApplicationDate = @applicationDate,
                            ApplicationTypeID = @applicationTypeID ,
                            ApplicationStatus= @applicationStatus,
                            LastStatusDate= @lastStatusDate,
                            PaidFees= @paidFees,
                            CreatedByUserID= @createdByUserID
                            WHERE ApplicationID = @applicationID";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            cmd.Parameters.AddWithValue( "@applicantPersonID", applicationPersonID );
            cmd.Parameters.AddWithValue( "@applicationDate", applicationDate );
            cmd.Parameters.AddWithValue( "@applicationTypeID", applicationTypeID );
            cmd.Parameters.AddWithValue( "@applicationStatus", applicationStatus );
            cmd.Parameters.AddWithValue( "@lastStatusDate", laststatusDate );
            cmd.Parameters.AddWithValue( "@paidFees", paidFees );
            cmd.Parameters.AddWithValue( "@createdByUserID", createdByUserId );

            try
            {
                connection.Open();
                rowaAffected = cmd.ExecuteNonQuery();

            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowaAffected > 0 );
        }
        public static bool DeleteApplication( int applicationID )
        {
            int rowaAffected = 0;
            SqlConnection connection = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "DELETE FROM Applications WHERE PersonID = @applicationID";

            SqlCommand cmd = new SqlCommand( query, connection );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connection.Open();
                rowaAffected = cmd.ExecuteNonQuery();
            }
            catch ( System.Exception ex )
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return ( rowaAffected > 0 );

        }

        public static bool IsApplicationExisits( string applicationID )
        {
            bool isFound = false;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT FOUND = 1 FROM Applications WHERE ApplicationID = @applicationID";
            SqlCommand cmd = new SqlCommand( query, connect );
            cmd.Parameters.AddWithValue( "@applicationID", applicationID );
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch ( Exception ex )
            {
                isFound = false;
            }
            finally
            {
                connect.Close();
            }
            return isFound;
        }
        public static int TotalApplications()
        {
            int total = 0;
            SqlConnection connect = new SqlConnection( DataAccesseSettings.DVLD_String );
            string query = "SELECT COUNT(*) FROM Applications";
            SqlCommand cmd = new SqlCommand( query, connect );
            try
            {
                connect.Open();
                object result = cmd.ExecuteScalar();
                if ( result != null && int.TryParse( result.ToString(), out int totallRows ) )
                {
                    total = totallRows;
                }
            }
            catch ( Exception ex )
            {

                //nothing
            }
            finally
            {
                connect.Close();
            }
            return total;
        }
    }
}

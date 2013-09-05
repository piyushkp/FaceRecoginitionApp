using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FaceRecoginition
{
    public class FaceDAO
    {
        public static int GetEntryIDByName(string name)
        {
            int entryID;

            using (SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["FaceDatabaseConnectionString"]))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_GetentryIDByName", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50);
                cmd.Parameters["@name"].Value = name.Trim().ToLower();

                cmd.Parameters.Add(new SqlParameter("@outEntryID", SqlDbType.Int)).Direction = ParameterDirection.Output;
                
                con.Open();
                cmd.ExecuteNonQuery();  // *** since you don't need the returned data - just call ExecuteNonQuery
                entryID = (int)cmd.Parameters["@outEntryID"].Value;
                con.Close();
            }

            return entryID;
        }

        public static FaceData GetFaceInfoByEntryID(int entryID)
        {
            FaceData _faceData = new FaceData();

            using (SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["FaceDatabaseConnectionString"]))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_GetFaceInfoByEntryID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@entryID", SqlDbType.Int);
                cmd.Parameters["@entryID"].Value = entryID;

                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50)).Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@emailID", SqlDbType.NVarChar, 100)).Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@album", SqlDbType.NVarChar, 50)).Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@albumkey", SqlDbType.NVarChar, 200)).Direction = ParameterDirection.Output;

                con.Open();

                cmd.ExecuteNonQuery();  // *** since you don't need the returned data - just call ExecuteNonQuery
                _faceData.name = cmd.Parameters["@name"].Value.ToString();
                _faceData.emailID = cmd.Parameters["@emailID"].Value.ToString();
                _faceData.album = cmd.Parameters["@album"].Value.ToString();
                _faceData.albumkey = cmd.Parameters["@albumkey"].Value.ToString();
                _faceData.entryid = entryID;
                con.Close();
            }

            return _faceData;
        }

        public static void InsertUserData(FaceData face)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["FaceDatabaseConnectionString"]))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_InsertUserData", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50);
                cmd.Parameters["@name"].Value = face.name;

                cmd.Parameters.Add("@emailID", SqlDbType.NVarChar, 100);
                cmd.Parameters["@emailID"].Value = face.emailID;

                cmd.Parameters.Add("@album", SqlDbType.NVarChar, 50);
                cmd.Parameters["@album"].Value = face.album;

                cmd.Parameters.Add("@albumkey", SqlDbType.NVarChar, 200);
                cmd.Parameters["@albumkey"].Value = face.albumkey;

                
                con.Open();

                cmd.ExecuteNonQuery();  // *** since you don't need the returned data - just call ExecuteNonQuery
                
                con.Close();
            }
        }
    }
}

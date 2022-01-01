using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PlagiarismChecker
{
    public class DatabaseController
    {
        private static string ConnectionString = "Data Source=DESKTOP-JM7LPJ2;Initial Catalog=PlagiarismChecker;Integrated Security=True";

        public static void InsertDocument(Dictionary<string , int> document)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            int id = GetID();
            conn.Open();
            foreach (KeyValuePair<string, int> entry in document)
            {
                SqlCommand comm = new SqlCommand("insert into DocumentsWordCount (ID,Word,Count) values(@a,@b,@c)", conn);
                comm.Parameters.Add(new SqlParameter("@a", id));
                comm.Parameters.Add(new SqlParameter("@b", entry.Key));
                comm.Parameters.Add(new SqlParameter("@c", entry.Value));
                comm.ExecuteNonQuery();
            }
            conn.Close();
        }

        private static int GetID()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand comm = new SqlCommand("select max(ID) from DocumentsWordCount", conn);
            conn.Open();
            int id = 0;
            SqlDataReader IDReader = comm.ExecuteReader();
            if (!IDReader.HasRows)
                id = -1;
            else
            {
                IDReader.Read();
                id = int.Parse(IDReader[0].ToString());
            }
            IDReader.Close();
            conn.Close();
            return id+1;
        }
        public static List<Dictionary<string , int>> getData()
        {
            List<Dictionary<string, int>> documentData = new List<Dictionary<string, int>>();
            int count = GetID();
            for(int i = 0; i<count; i++)
            {
                documentData.Add(new Dictionary<string, int>());
            }
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand getData = new SqlCommand("Select * from DocumentsWordCount", conn);

            SqlDataReader Data = getData.ExecuteReader();
            while (Data.Read())
            {
                // 0 id    1 order  2 high  3 low   4 date
                documentData[int.Parse(Data[0].ToString())].Add(Data[1].ToString(),int.Parse(Data[2].ToString()));
            }

            Data.Close();
            conn.Close();

            return documentData;
        }

    }
}

// insert into PlagiarismChecker.dbo.DocumentsWordCount (ID,Word,Count) values (0 ,'sdasdsdfdsf' , 0);
//DELETE FROM PlagiarismChecker.dbo.DocumentsWordCount;
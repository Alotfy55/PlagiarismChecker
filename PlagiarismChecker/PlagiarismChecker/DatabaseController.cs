using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PlagiarismChecker
{
    public class DatabaseController
    {
        // Document Database Controller
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

        // Users Database Controller
        public bool checkUsernameAvailability(string username)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from Users where Username = @x", conn);
            comm.Parameters.Add(new SqlParameter("@x", username));

            SqlDataReader DataReader = comm.ExecuteReader();
            bool available = false;

            if (!DataReader.HasRows)
                available = true;
            else
                available = false;

            DataReader.Close();
            conn.Close();

            return available;
        }

        public void insertData(string username, string password)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into Users (Username,Password) values(@a,@b)", conn);
            comm.Parameters.Add(new SqlParameter("@a", username));
            comm.Parameters.Add(new SqlParameter("@b", password));
            conn.Close();
        }

        public bool checkPassword(string username, string Password)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select Password from Users where Username = @x and Password = @y ", conn);
            comm.Parameters.Add(new SqlParameter("@x", username));
            comm.Parameters.Add(new SqlParameter("@y", Password));

            SqlDataReader DataReader = comm.ExecuteReader();
            bool correct = false;
            if (!DataReader.HasRows)
                correct = false;
            else
                correct = true;

            DataReader.Close();
            conn.Close();

            return correct;
        }

        // DocumentsSimilarity Database Controller
        public List<SimilarityReading> GetUserHistory(string username)
        {

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand getData = new SqlCommand("Select * from DocumentsSim where Username = @a", conn);
            getData.Parameters.Add(new SqlParameter("@a", username));

            SqlDataReader Data = getData.ExecuteReader();

            List<SimilarityReading> UserDocHistory = new List<SimilarityReading>();

            while (Data.Read())
            {
                // 0 id    1 order  2 high  3 low   4 date
                UserDocHistory.Add(new SimilarityReading(Data[2].ToString() , Data[3].ToString() , float.Parse(Data[4].ToString() )));
            }

            Data.Close();
            conn.Close();
            return UserDocHistory;
        }

    }
    public class SimilarityReading
    {
        string doc1Name;
        string doc2Name;
        float similarity;

        public SimilarityReading(string doc1Name, string doc2Name, float similarity)
        {
            this.doc1Name = doc1Name;
            this.doc2Name = doc2Name;
            this.similarity = similarity;
        }
        public SimilarityReading()
        {
            this.doc1Name = "";
            this.doc2Name = "";
            this.similarity = 0;
        }
    }
}

// insert into PlagiarismChecker.dbo.DocumentsWordCount (ID,Word,Count) values (0 ,'sdasdsdfdsf' , 0);
//DELETE FROM PlagiarismChecker.dbo.DocumentsWordCount;
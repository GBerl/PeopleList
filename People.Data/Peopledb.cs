using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace People.Data
{
    public class Peopledb
    {
        private string _connection;
        public Peopledb(string connection)
        {
            _connection = connection;
        }
        public List<Person> ShowAllPeople()
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "Select * from People";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Person> people = new List<Person>();
                while (reader.Read())
                {
                    people.Add(new Person
                    {
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Age = (int)reader["Age"],
                        Id = (int)reader["Id"]

                    });
                }
                return people;
            }


        }
    }
}

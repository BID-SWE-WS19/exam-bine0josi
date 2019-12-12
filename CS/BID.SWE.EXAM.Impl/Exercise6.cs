using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            string query = "INSERT INTO TestAbgaben (Id, Tag, Monat, Jahr, Stunde, Minute, Name) " +
                   "VALUES (@ID, @Tag, @Monat, @Jahr, @Stunde, @Minute, @Jahr) ";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@ID", 34);
                    cmd.Parameters.AddWithValue("@Tag", 12);
                    cmd.Parameters.AddWithValue("@Monat", 12);
                    cmd.Parameters.AddWithValue("@Jahr", 2019);
                    cmd.Parameters.AddWithValue("@Stunde", 16);
                    cmd.Parameters.AddWithValue("@Minute", 40);
                    cmd.Parameters.AddWithValue("@Name", "Philippine");

                    return cmd;
                }
        }
    }
}
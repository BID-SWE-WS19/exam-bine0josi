using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            int id = 34;
            int tag = 12;
            int monat = 12;
            int jahr = 2019;
            int stunde = 17;
            int minute = 10;
            string name = "Philippine";
            string query = "INSERT INTO TestAbgaben (Id, Tag, Monat, Jahr, Stunde, Minute, Name) " +
                   "VALUES (@ID, @Tag, @Monat, @Jahr, @Stunde, @Minute, @Jahr, @Name) ";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Tag", tag);
                    cmd.Parameters.AddWithValue("@Monat", monat);
                    cmd.Parameters.AddWithValue("@Jahr", jahr);
                    cmd.Parameters.AddWithValue("@Stunde", stunde);
                    cmd.Parameters.AddWithValue("@Minute", minute);
                    cmd.Parameters.AddWithValue("@Name", name);

                    return cmd;
                }
        }
    }
}
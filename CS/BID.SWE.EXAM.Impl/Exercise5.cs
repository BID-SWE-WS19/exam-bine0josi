using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> messages = new List<string>();

            TcpClient client = new TcpClient(str, i);
            var stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);

            while (reader.EndOfStream)
            {
                messages.Add(reader.ReadLine());
            }

            return messages;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONHandle
{
    public class Person
    {
        public int ID;
        public string Name;
        public string LastName;
        public DateTime Birthday;
        public float Weight;
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (System.IO.StreamReader _StreamReader = new System.IO.StreamReader(@"C:\Users\PC-1\Desktop\c#Json\JsonGetdata\JsonGetdata\person.json"))
            {
                string jsonData = _StreamReader.ReadToEnd();
                List<Person>? listPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(jsonData);

                foreach (var _Person in listPerson)
                {
                    Console.WriteLine("{0} {1}", _Person.Name, _Person.LastName);
                }
            }
        }
    }
}
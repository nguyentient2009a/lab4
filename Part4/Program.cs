using System;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person personEmployee = new Student("tien", "0971628002", "tiennguuuen@gmail.com", "engineer");
            Console.WriteLine(personEmployee.ToString());
        }
    }
}
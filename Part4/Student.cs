namespace Part4
{
    public class Student : Person
    {
        public string Program { get; set; }

        public Student()
        {
        }

        public Student(string program)
        {
            Program = program;
        }

        public Student(string name, string phone, string email, string program) : base(name, phone, email)
        {
            Program = program;
        }
    }
}
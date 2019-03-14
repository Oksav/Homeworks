


namespace Homework4
{
    class School
    {
        public class Student
        {
            public string Name { get; set; }
            public string Academy { get; set; }
            public string Group { get; set; }

            public Student(string name, string academy, string group)
            {
                this.Name = name;
                this.Academy = academy;
                this.Group = group;

            }
        }
    }
}

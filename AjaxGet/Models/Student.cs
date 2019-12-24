namespace AjaxGet.Models
{
    public class Student
    {
        public string Name { get; set; }
        public float Mark { get; set; }

        public Student() { }
        public Student(string name, float mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
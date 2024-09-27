
namespace CourseHash_Exercise.Entitites
{
    internal class Student
    {
        public int Code { get; set; }

        public Student(int code)
        {
            Code = code;
        }


        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student)) { return false; }
            Student other = obj as Student;
            return Code.Equals(other.Code);
        }
    }
}

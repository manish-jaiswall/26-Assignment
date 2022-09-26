namespace AssignmentSolution
{
    public class Student<T>
    {
        public void display(int id, T name, T pass)
        {
            Console.WriteLine("[" + id + "," + name + "," + pass + "]");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<string> student = new Student<string>();
            student.display(1, "Hari", "Y");
            student.display(2, "Manish", "Y");
            student.display(3, "Sita", "N");
            student.display(4, "Geeta", "Y");
            student.display(5, "Niraj", "Y");
        }
    }
}
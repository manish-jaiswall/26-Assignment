namespace Assignment2StudentIDMArks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students you want to store");
            int n=Convert.ToInt32(Console.ReadLine());
            var si=new SortedDictionary<int,int>();

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the id of the student");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the marks of the student");
                int marks=Convert.ToInt32(Console.ReadLine());  

                si.Add(id, marks);
            }
            Console.WriteLine("The list of students are: ");

            foreach(KeyValuePair<int,int> pair in si)
            {
                Console.WriteLine(pair.Key+" "+pair.Value); ;
            }

        }
    }
}
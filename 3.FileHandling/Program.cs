namespace _3.FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\Training\\11\\3.FileHandling\\f1.txt", FileMode.OpenOrCreate);
            fs.WriteByte(66);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Write");
            sw.WriteLine("Next Line");
            /*sw.Close();*/
            /*fs.Close();*/
            StreamReader sr = new StreamReader(fs);
        
            string content="";
            while((content=sr.ReadLine())!=null)
            {
                /*content=sr.ReadLine();*/
                Console.WriteLine(content);
            }
            Console.WriteLine("Enter the text you want to append");
            string s=Console.ReadLine();
            sw.WriteLine(s);



            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
}
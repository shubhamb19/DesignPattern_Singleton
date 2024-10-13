namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Singleton s1 = Singleton.GetInstance();

          Singleton s2 = Singleton.GetInstance();
            if (s1 != s2) 
            {
                Console.WriteLine("Not shearing the same responce");           
            }
            else 
            {
                Console.WriteLine(" shearing the same responce");
                Console.WriteLine("Shubhm");
            }
            Console.ReadLine();
        }
    }
}

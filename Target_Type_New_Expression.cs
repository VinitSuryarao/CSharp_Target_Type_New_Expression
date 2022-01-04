using System;

namespace InitOnly
{
    public record Company
    {
        public Company(int v1, string v2, string v3)
        {
            ID = v1;
            Name = v2;
            City = v3;
        }

        public int ID { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company obj1 = new(1,"ABC","Mumbai");
            Console.WriteLine(obj1.ID.ToString() + " " + obj1.Name + " " + obj1.City);  
            Console.ReadLine();
        }
    }
}

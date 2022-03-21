using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{
    class StringTesting
    {
        static void Main(string[] args)
        {
            string name = "Magnus Andersson";
            string hobby = "Save earth";

            if (name.StartsWith("Magnus"))
            {
                Console.WriteLine("Name begins with Magnus");
            }
            if (name == "Magnus Andersson")
            {
                Console.WriteLine("Name is Magnus Andersson");
            }
            if(name.ToLower().Contains("andersson"))
            {
                Console.WriteLine("Belongs to the Andersson family");
            }

            //name = name.ToLower();
            //hobby = hobby.ToUpper();

            hobby = hobby.Replace("earth", "the world");

            hobby = hobby.Trim();


            string[] list = name.Split(' ');
            Console.WriteLine($"Firstname is {list[0]}");
            Console.WriteLine($"Lastname is {list[1]}");


            string wholename = name + " trying to " + hobby;
            Console.WriteLine(wholename);

            name = name.Substring(7, 9);

            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Hobby = {hobby}");
            Console.Read();
        }
    }
}

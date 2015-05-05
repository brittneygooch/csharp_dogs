using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dgs = new Dog();
            dgs.Name = "Lucky";
            dgs.breed = "yorkie";
            dgs.color = "black";

            Dog dgs2 = new Dog();
            dgs2.Name = "Ruckus";
            dgs2.breed = "boxer";
            dgs2.color = "brown";

            Dog dgs3 = new Dog();
            dgs3.Name = "Lady";
            dgs3.breed = "Chow";
            dgs3.color = "black & brown";

            List<Dog> pups = new List<Dog>();
            pups.Add(dgs);
            pups.Add(dgs2);
            pups.Add(dgs3);

            foreach (var item in pups)
            {
                Console.WriteLine(item.Name + " is a " + item.color + " " + item.breed );
            }
            Console.ReadLine(); 
        }
    }
}

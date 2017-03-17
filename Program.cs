using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericDictionary
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Create generic list of states
            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("az", "Arizona");
            states.Add("wi", "Wisconsin");
            states.Add("il", "Illinois");

            Console.WriteLine(states["az"]);

            Console.ReadLine();


        }
    }
}

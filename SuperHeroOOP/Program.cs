using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhero batman = new Superhero("Batman" , true);
            Console.WriteLine(batman.Name);
            Console.WriteLine("Is your superhero a superhero??  {0}", batman.IsSuperhero);

            string[] supermanAbilities = new string[3]; 

            Superhero superman = new Superhero("Superman", "Lex Luthor", "Clark Kent", supermanAbilities);
            Console.WriteLine(superman.Nemesis);
            Console.WriteLine(superman.SecretIdentity);
        }

    }
}

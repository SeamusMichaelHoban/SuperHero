using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class Superhero
    {// declaring fields
        private string name;
        private string nemesis;
        private string secretIdentity;
        private string[] specialAbilities;
        private bool isSuperhero;

        //declaring properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Nemesis
        {
            get { return this.nemesis; }
            set { this.nemesis = value; }
        }

        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }

        public bool IsSuperhero
        {
            get { return this.isSuperhero; }
            set { this.isSuperhero = value; }
        }
        //public int Weight
        //{
        //    get { return this.weight; }
        //    set { this.weight = value; }
        //}

        //creating 3 constructor methods
        public Superhero()
        {

        }
        
        public Superhero(string name, bool isSuperhero)
        {
            this.isSuperhero = isSuperhero;
            this.name = name;
        }

        public Superhero( string name, string nemesis, string secretIdentity, string[] specialAbilities)
        {
            isSuperhero = true;
            this.name = name;
            this.nemesis = nemesis;
            this.secretIdentity = secretIdentity;
            this.specialAbilities = specialAbilities;
        }

        




    }
}

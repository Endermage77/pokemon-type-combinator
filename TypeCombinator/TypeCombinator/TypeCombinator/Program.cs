using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCombinator
{
    class Program
    {
        //The master lists with all the words.
        public static string[] types = new string[] { "Normal", "Fighting", "Flying", "Posion", "Ground", "Rock", "Bug", "Ghost", "Steel", "Fire", "Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Dark", "Fairy" };
        public static string[] consonant_attributes = new string[] { "", "mechanical", "ringed", "monstrous", "small", "cloaked", "boreal", "big-armed", "spotty", "sparkling", "big-headed", "common", "long-legged", "ball-shaped", "cave-dwelling", "winged", "stubby-limbed", "finned", "geomtric", "bony", "shelled", "toothy", "floating", "slimy"};
        public static string[] vowel_attributes = new string[] { "artificial", "arboreal", "alien", "enourmous", "elusive", "armored", "extraterrestrial" };
        public static string[] shapes = new string[] { "blob", "insect", "bird", "fish", "mineraloid", "canine", "cephalopod", "swarm", "plant", "fungus", "dinosaur", "humanoid", "serpent", "feline", "lizard", "reptile", "rodent", "beast", "fossil"};
        public static string[] consonant_natures = new string[] { "soft", "fierce", "vacuous", "dull", "sophisticated", "primal", "secretive", "shy", "territorial", "passé", "curious", "wicked", "cunning", "civilized", "domestic", "magical", "stoic", "defiant", "fretful", "clingy", "bemused", "sour", "torpid", "mischievous", "tough", "laid-back", "rough", "bitter", "placid", "peaceful" };
        public static string[] vowel_natures = new string[] { "elegant", "ancient", "optimistic", "ordinary", "otherworldly", "enthusiastic", "unusual", "intelligent", "empty", "obedient", "innocent", "animated", "angelic", "unremarkable", "earthy"};

        static void Main(string[] args)
        {
            //Declaring this integer for later use in RNG calls.
            int i;

            //Printing word bank stats.
            Console.WriteLine("Word Bank statistics: " + types.Length + " pokémon types. " + shapes.Length + " shapes.");
            Console.WriteLine(consonant_attributes.Length + " consonant attributes. " + vowel_attributes.Length + " vowel attributes.");
            Console.WriteLine(consonant_natures.Length + " consonant natures. " + vowel_natures.Length + " vowel natures.");
            Console.WriteLine("");

            while (true)
            {
                //Declaring variables for pokemon type.
                Random rand = new Random();
                string type, pType, sType;
                int pIndex, sIndex;


                //Randomly rolling the two types.
                pIndex = rand.Next(types.Length);
                pType = types[pIndex];

                sIndex = rand.Next(types.Length);
                sType = types[sIndex];

                //Roll to determine if this is mono-type or dual-type.
                //If both types are the same, just print it once and not twice: We only need Steel and not Steel/Steel.
                i = rand.Next(10);
                if (pIndex == sIndex || i <= 4)
                    {
                    type = pType;
                    }
                else 
                    {
                    type = pType + "/" + sType;
                    }


                //Rolling to pick between consonants or vowels, then rolling for attribute.
                i = rand.Next(10);
                string attribute;
                if (i <= 7)
                {
                    attribute = "a " + consonant_attributes[rand.Next(consonant_attributes.Length)];
                }
                else
                {
                    attribute = "an " + vowel_attributes[rand.Next(vowel_attributes.Length)];
                }

                //Rolling for shape.
                string shape = shapes[rand.Next(shapes.Length)];

                //Rolling to pick between consonants or vowels, then rolling for nature.
                i = rand.Next(10);
                string nature;
                if (i <= 6)
                {
                    nature = "a " + consonant_natures[rand.Next(consonant_natures.Length)];
                }
                else
                {
                    nature = "an " + vowel_natures[rand.Next(vowel_natures.Length)];
                }


                //Printing out the final result
                Console.WriteLine("Generated " + attribute + " " + type + "-type " + shape + " pokémon. It has " + nature + " nature.");
                Console.WriteLine("Press enter to generate a new pokémon.");
                string input = Console.ReadLine();
            }

        }
    }
}

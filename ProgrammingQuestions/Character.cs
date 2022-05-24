using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQuestions
{
    //Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare.
    //Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som
    //sparas i en instans av en klass.
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }

        public Character(string name, int health, int strength, int luck)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Luck = luck;
        }
    }
}

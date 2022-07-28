using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string name { get; set; }   
    }
}

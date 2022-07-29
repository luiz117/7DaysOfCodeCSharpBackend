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
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pokemon()
        {
            Random valorRandomico = new();
            Alimentacao = valorRandomico.Next(2, 10);
            Humor = valorRandomico.Next(2, 10);
            DataNascimento = DateTime.Now;
        }

        public bool VerificarFome()
        {
            return this.Alimentacao < 5;
        }
        public void AlimentarMascote()
        {
            this.Alimentacao++;
        }

        public void BrincarMascote()
        {
            this.Humor++;
            this.Alimentacao--;
        }

        public bool SaudeMascote()
        {
            return (this.Alimentacao > 0 && this.Humor > 0);
        }



    }
}

using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Mascote
    {
        public List<Abilities> Habilidades { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Nome { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public Mascote() 
        {
            Random valorRandomico = new();
            Alimentacao = valorRandomico.Next(2, 10);
            Humor = valorRandomico.Next(2, 10);
            DataNascimento = DateTime.Now;
        }

        /// <summary>
        /// Verifica se o mascote tem fome
        /// </summary>
        /// <returns>True = Sim False = Não</returns>
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

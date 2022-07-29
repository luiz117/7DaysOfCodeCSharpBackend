using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi;

namespace Tamagotchi
{
    public class TamagotchiView
    {
        private string nameJogador { get; set; }
        public TamagotchiView()
        {
            BoasVindas();
        }
        public void BoasVindas()
        {
            Console.WriteLine(@" 
     #######                                                                    
        #       ##    #    #    ##     ####    ####   #####   ####   #    #  # 
        #      #  #   ##  ##   #  #   #    #  #    #    #    #    #  #    #  # 
        #     #    #  # ## #  #    #  #       #    #    #    #       ######  # 
        #     ######  #    #  ######  #  ###  #    #    #    #       #    #  # 
        #     #    #  #    #  #    #  #    #  #    #    #    #    #  #    #  # 
        #     #    #  #    #  #    #   ####    ####     #     ####   #    #  #");

            Console.WriteLine("\n\nQual é seu name?");
            nameJogador = Console.ReadLine().ToUpper();
        }

        public void MenuInicial()
        {
            Console.WriteLine("\n\n--------------------------- MENU ---------------------------");
            Console.WriteLine($"{nameJogador} Você deseja:");
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus macotes");
            Console.WriteLine("3 - Sair");
        }
        public string MenuAdocao()
        {
            Console.WriteLine("\n--------------------- ADOTAR UM MASCOTE ---------------------");
            Console.WriteLine($"{nameJogador} Escolha uma espécie:");
            Console.WriteLine("BULBASAUR");
            Console.WriteLine("IVYSAUR");

            return Console.ReadLine().ToUpper();
        }
        public string DesejaSaberMais(string especie)
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"{nameJogador} VOCÊ DESEJA:");
            Console.WriteLine($"1 - SABER MAIS SOBRE O {especie}");
            Console.WriteLine($"2 - ADOTAR {especie}");
            Console.WriteLine($"3 - VOLTAR");

            return Console.ReadLine().ToUpper();
        }

        public void DetalhesMascote(Pokemon Pokemon)
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine("name Pokemon: " + Pokemon.name.ToUpper());
            Console.WriteLine("Altura: " + Pokemon.height);
            Console.WriteLine("Peso: " + Pokemon.weight);

            Console.WriteLine("Habilidades: ");
            foreach (Abilities habilidade in Pokemon.abilities)
            {
                Console.Write(habilidade.ability.name.ToUpper() + " ");
            }
        }

        public void DetalhesMascoteAdotado(Pokemon pokemon)
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine("name Pokemon: " + pokemon.name.ToUpper());
            Console.WriteLine("Altura: " + pokemon.height);
            Console.WriteLine("Peso: " + pokemon.weight);

            System.TimeSpan idade = DateTime.Now.Subtract(pokemon.DataNascimento);

            Console.WriteLine("Idade: " + idade.Minutes + " Anos em Pokemon Virtual");

            if (pokemon.VerificarFome())
                Console.WriteLine($"{pokemon.name.ToUpper()} Está com fome!");
            else
                Console.WriteLine($"{pokemon.name.ToUpper()} Está alimentado!");

            if (pokemon.Humor > 5)
                Console.WriteLine($"{pokemon.name.ToUpper()} Está feliz!");
            else
                Console.WriteLine($"{pokemon.name.ToUpper()} Está triste!");

            Console.WriteLine("Habilidades: ");
            foreach (Abilities habilidade in pokemon.abilities)
            {
                Console.Write(habilidade.ability.name.ToUpper() + " ");
            }
        }

        public void SucessoAdocao()
        {
            Console.WriteLine($"{nameJogador} Pokemon ADOTADO COM SUCESSO, O OVO ESTÁ CHOCANDO: ");

            Console.WriteLine(@"
              ███╗
             ██████╗
            ████████╗
            ████████║
            ████████║
            ╚█████╔╝
             ╚════╝");
        }

        public int MenuConsultarMascotes(List<Pokemon> Pokemons)
        {
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"Você possui {Pokemons.Count} Pokemon adotados.");
            for (int indicePokemon = 0; indicePokemon < Pokemons.Count; indicePokemon++)
            {
                Console.WriteLine($"{indicePokemon} - {Pokemons[indicePokemon].name.ToUpper()}");
            }

            Console.WriteLine($"Qual Pokemon você deseja interagir?");
            return Convert.ToInt32(Console.ReadLine());
        }


    }

}

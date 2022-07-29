using System;
using System.Collections.Generic;
using Tamagotchi;

namespace Tamagotchi
{
    class Program
    {
        static void Main()
        {          
            List<Pokemon> MascotesAdotados;  
            MascotesAdotados = new List<Pokemon>();

            string opcaoUsuario;
            int jogar = 1;

            while (jogar == 1)
            {
                Console.WriteLine("1 - Adotar um mascote virtual");
                Console.WriteLine("3 - Sair");

                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1":
                        string opcaoUsuarioSubMenu = "1", especieMascote;
                        Pokemon pokemon = new();

                        Console.WriteLine($"Escolha uma espécie:");
                        Console.WriteLine("BULBASAUR");
                        Console.WriteLine("IVYSAUR");
                        Console.WriteLine();
                        especieMascote = Console.ReadLine();


                        while (opcaoUsuario != "3")
                        {
                            Console.WriteLine($"1 - SABER MAIS SOBRE O {especieMascote}");
                            Console.WriteLine($"2 - ADOTAR {especieMascote}");
                            Console.WriteLine($"3 - VOLTAR");
                            Console.WriteLine();

                            opcaoUsuarioSubMenu = Console.ReadLine();

                            switch (opcaoUsuarioSubMenu)
                            {
                                case "1":
                                    pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                                    Console.WriteLine("name Pokemon: " + pokemon.name.ToUpper());
                                    Console.WriteLine("Altura: " + pokemon.height);
                                    Console.WriteLine("Peso: " + pokemon.weight);

                                    Console.WriteLine("Habilidades: ");
                                    foreach (Abilities habilidade in pokemon.abilities)
                                    {
                                        Console.Write(habilidade.ability.name.ToUpper() + " ");
                                    }
                                    Console.WriteLine();

                                    break;

                                case "2":
                                    pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                                    MascotesAdotados.Add(pokemon);
                                    Console.WriteLine($"MASCOTE ADOTADO COM SUCESSO, O OVO ESTÁ CHOCANDO");
                                    Console.WriteLine();

                                    opcaoUsuario = "3";
                                    break;

                                case "3":
                                    opcaoUsuario = "3";
                                    break;

                                default:
                                    Console.WriteLine("Opção Inválida! Tente Novamente: ");
                                    break;
                            }
                        }
                        break;
                   
                    case "3":
                        jogar = 0;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente. ");
                        break;
                }
            }
        }        
    }
}

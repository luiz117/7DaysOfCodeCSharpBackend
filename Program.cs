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
            TamagotchiView Mensagens;

            MascotesAdotados = new List<Pokemon>();
            Mensagens = new TamagotchiView();

            string opcaoUsuario;
            int jogar = 1;

            while (jogar == 1)
            {
                Mensagens.MenuInicial();
                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1":
                        string opcaoUsuarioSubMenu = "1", especieMascote;
                        Pokemon pokemon = new();

                        especieMascote = Mensagens.MenuAdocao();

                        while (opcaoUsuario != "3")
                        {
                            opcaoUsuarioSubMenu = Mensagens.DesejaSaberMais(especieMascote);

                            switch (opcaoUsuarioSubMenu)
                            {
                                case "1":
                                    pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                                    Mensagens.DetalhesMascote(pokemon);
                                    break;

                                case "2":
                                    pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                                    MascotesAdotados.Add(pokemon);
                                    Mensagens.SucessoAdocao();
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
                    case "2": //interacao
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

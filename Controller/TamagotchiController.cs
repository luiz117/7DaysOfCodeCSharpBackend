using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tamagotchi;

namespace Tamagotchi
{
    public class TamagotchiController
    {
        private string NomeJogador { get; set; }
        private List<Pokemon> MascotesAdotados { get; set; }
        private TamagotchiView Mensagens { get; set; }


        public TamagotchiController()
        {
            this.MascotesAdotados = new List<Pokemon>();
            this.Mensagens = new TamagotchiView();
        }

        public void Jogar()
        {
            string opcaoUsuario;
            int jogar = 1;

            while (jogar == 1)
            {
                Mensagens.MenuInicial();
                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1":
                        MenuAdocao();
                        break;
                    case "2":
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
        private void MenuAdocao()
        {
            string opcaoUsuario = "1", especieMascote;
            Pokemon pokemon = new();


            especieMascote = Mensagens.MenuAdocao();

            while (opcaoUsuario != "3")
            {
                opcaoUsuario = Mensagens.DesejaSaberMais(especieMascote);

                switch (opcaoUsuario)
                {
                    case "1":
                        pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                        Mensagens.DetalhesMascote(pokemon);
                        break;

                    case "2":
                        pokemon = PokemonService.BuscarCaracteristicasPorEspecie(especieMascote);
                        this.MascotesAdotados.Add(pokemon);
                        Mensagens.SucessoAdocao(NomeJogador);
                        return;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente: ");
                        break;
                }
            }
        }
    }
}

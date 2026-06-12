using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5) //diferente
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
                Console.ResetColor();
                Console.WriteLine("\n 1-cadastro animes");
                Console.WriteLine("\n 2-cadastro de supers");
                Console.WriteLine("\n 3-cadastro cadastro de series");
                Console.WriteLine("\n 4-cadastro de locadora de vhs");
                Console.WriteLine("\n 5-cadastro de oficina de mecanica");
                Console.WriteLine("\n 6-cadastro de livro ");
                Console.WriteLine("\n 7-cadastro de restaurante cardapio");
                Console.WriteLine("\n 8-cadastro de jogos");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("digite a opcao escolhida:");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastro_anime();
                        break;
                    case 2:
                        cadastro_se_supers();
                        break;
                    case 3:
                        cadatros_de_series();
                        break;
                    case 4:
                        cadastro_de_locadora_vhs();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;



                }


            }
        }




        static void cadastro_anime()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░███╗░░██╗██╗███╗░░░███╗███████╗
██╔══██╗████╗░██║██║████╗░████║██╔════╝
███████║██╔██╗██║██║██╔████╔██║█████╗░░
██╔══██║██║╚████║██║██║╚██╔╝██║██╔══╝░░
██║░░██║██║░╚███║██║██║░╚═╝░██║███████╗
╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░░░░╚═╝╚══════╝");
            Console.ResetColor();
            Console.WriteLine("\n titulo:");
            string tituloanime = Console.ReadLine();
            Console.WriteLine("\n qnts episodios:");
            string qntsepisodios = Console.ReadLine();
            Console.WriteLine("\n ano lançado:");
            string anolançamento = Console.ReadLine();
            Console.WriteLine("\n personagem principal:");
            string personagemprincipal = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string categoriaanime = Console.ReadLine();
            Console.WriteLine("\n classificação:");
            string classificaçãoanime = Console.ReadLine();
            Console.WriteLine("\n avaliação:");
            string avaliaçãoanime = Console.ReadLine();

        }
        static void cadastro_se_supers()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ░██████╗██╗░░░██╗██████╗░███████╗██████╗░░██████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔════╝██║░░░██║██╔══██╗██╔════╝██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ╚█████╗░██║░░░██║██████╔╝█████╗░░██████╔╝╚█████╗░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ░╚═══██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██████╔╝
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░");


            Console.ResetColor();
            Console.WriteLine("\n nome:");
            string nomesupers = Console.ReadLine();
            Console.WriteLine("\n apelido:");
            string apelidosupers = Console.ReadLine();
            Console.WriteLine("\n data de nascimento:");
            string datanascimento = Console.ReadLine();
            Console.WriteLine("\n altura:");
            string alturasupers = Console.ReadLine();
            Console.WriteLine("\n peso:");
            string pesosupers = Console.ReadLine();
            Console.WriteLine("\n gênero:");
            string generosupers = Console.ReadLine();
            Console.WriteLine("\n descrição do traje:");
            string descricaotraje = Console.ReadLine();
            Console.WriteLine("\n habilidades:");
            string habilidadessupers = Console.ReadLine();
            Console.WriteLine("\n poderes:");
            string poderessupers = Console.ReadLine();
            Console.WriteLine("\n pontos fortes:");
            string pontosfortes = Console.ReadLine();
            Console.WriteLine("\n fraquezas:");
            string fraquezassupers = Console.ReadLine();
            Console.WriteLine("\n inimigos:");
            string inimigosssupers = Console.ReadLine();
            Console.WriteLine("\n quantidades de aliados:");
            string qntaliados = Console.ReadLine();

        }
        static void cadatros_de_series()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░██████╗███████╗██████╗░██╗███████╗░██████╗
██╔════╝██╔════╝██╔══██╗██║██╔════╝██╔════╝
╚█████╗░█████╗░░██████╔╝██║█████╗░░╚█████╗░
░╚═══██╗██╔══╝░░██╔══██╗██║██╔══╝░░░╚═══██╗
██████╔╝███████╗██║░░██║██║███████╗██████╔╝
╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝╚══════╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n titulo:");
            string tituloanime = Console.ReadLine();
            Console.WriteLine("\n qtd de episodio:");
            string qntsepisodios = Console.ReadLine();
            Console.WriteLine("\n qtd de temporada:");
            string anolançamento = Console.ReadLine();
            Console.WriteLine("\n ano:");
            string personagemprincipal = Console.ReadLine();
            Console.WriteLine("\n personagem principas:");
            string categoriaanime = Console.ReadLine();
            Console.WriteLine("\n vilão:");
            string classificaçãoanime = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string avaliaçãoanime = Console.ReadLine();
            Console.WriteLine("\n classificação");
            string classificação = Console.ReadLine();  



        }
        static void cadastro_de_locadora_vhs()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██╗░░░░░░█████╗░░█████╗░░█████╗░██████╗░░█████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗░░██╗░██████╗
██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║░░██║██╔════╝
██║░░░░░██║░░██║██║░░╚═╝███████║██║░░██║██║░░██║██████╔╝███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝███████║╚█████╗░
██║░░░░░██║░░██║██║░░██╗██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██╔══██║░╚═══██╗
███████╗╚█████╔╝╚█████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║░░██║██████╔╝
╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n titulo:");
            string tituloanime = Console.ReadLine();
            Console.WriteLine("\n ano:");
            string qntsepisodios = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string anolançamento = Console.ReadLine();
            Console.WriteLine("\n livre ou emprestado:");
            string livreouemprstado = Console.ReadLine();   



        }

}
}
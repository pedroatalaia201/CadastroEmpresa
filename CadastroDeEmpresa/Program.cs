using System;
using System.Globalization;

namespace CadastroDeEmpresa {
    class Program {
        static public Menu MenuScreen { get; set; }
        static public int Op;

        static void Main(string[] args) {
            /*
             * Criar um programa que crie um cadastro de empresa com:
             * Id( de 3 númeors que não pode se repetir);
             * Nome(não pode se repetir);
             * Receita(pode ser alterada caso o usuário faça o login com o Id e o Nome);
             * E possua opção de se alterar a Receita por meio de despesas e Prejuizo e/ou Lucro;
            */


            do {
                Console.WriteLine("Menu-------------------\n1- Cadastra empresa;");
                Console.WriteLine("2- Editar empresa;\n3- Ajuda;\n4- Sair;");
                Console.Write("Opção desejada: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op) {
                    case 1:
                        //preciso cria um método para isso...
                        Random rand = new Random();

                        int id = rand.Next(100, 999);
                        string nome;
                        double receita;

                        Console.WriteLine($"Id gerado: {id}");
                        Console.Write("Escreva o nome da empresa: ");
                        nome = Console.ReadLine();

                        Console.Write("Escreva o valor de receita: R$ ");
                        receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Empresa empresa = new Empresa(id, nome, receita);
                        MenuScreen.AddEmpresa(empresa);

                        Console.WriteLine("Cadastro efetuado com sucesso;\n");

                        break;

                    case 2:
                        MenuScreen.FindEmpresa();
                        break;

                    case 3:
                        MenuScreen.MenuHelp();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }               
                Console.WriteLine();
            } while (Op != 4);

        }
    }
}

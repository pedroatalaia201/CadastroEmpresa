using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroDeEmpresa {
    class Program {       
        static int Op;
        static List<Empresa> empresa = new List<Empresa>();

        static void Main(string[] args) {
            
            do {
                Console.WriteLine("Menu-------------------\n1- Cadastra empresa;");
                Console.WriteLine("2- Editar empresa;\n3- Exibir empresas cadastradas;\n4- Ajuda;\n5- Sair;");
                Console.Write("Opção desejada: ");
                Op = int.Parse(Console.ReadLine());
                

                switch (Op) {
                    case 1:                      
                        Random rand = new Random();

                        int id = rand.Next(100, 999);
                        string nome;
                        double receita;

                        Console.WriteLine($"Id gerado: {id}");
                        Console.Write("Escreva o nome da empresa: ");
                        nome = Console.ReadLine();

                        Console.Write("Escreva o valor de receita: R$ ");
                        receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                        empresa.Add(new Empresa(id, nome, receita));

                        Console.WriteLine("Cadastro efetuado com sucesso;\n");

                        break;

                    case 2:
                        EditarEmpresa();
                   
                        break;

                    case 3:
                        Exibir();
                        break;

                    case 4:
                        MenuHelp();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }               
                Console.WriteLine();
            } while (Op != 5);

        }

        static void EditarEmpresa() {
            
            Console.WriteLine("Digite o Id e o Nome da sua empresa");

            Console.Write("Digite o id da empresa: ");
            int find = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da empresa: ");
            string nome = Console.ReadLine();

            foreach (Empresa cadastro in empresa) {
                if (cadastro.Id == find && cadastro.Nome == nome) {

                    Console.WriteLine("Você deseja:\n1- Adicionar Lucro;\n2- Adicionar Despeza;");
                    int op = int.Parse(Console.ReadLine());

                    Console.Write("Qual a quantia? R$");
                    double quantia = double.Parse(Console.ReadLine());

                    if (op == 1) {
                        cadastro.AddLucro(quantia);                        
                    }
                    else {
                        cadastro.AddDespesa(quantia);                                                   
                    }

                    return;
                }
            }
            Console.WriteLine("Empresa não enconttrada.");
        }

        static void Exibir() {
            foreach(Empresa obj in empresa) {
                Console.WriteLine("---------------");
                Console.WriteLine("Empresa: " + obj.Nome);
                Console.WriteLine("Id: " + obj.Id);
                Console.WriteLine("Receita: R$ " + obj.Receita);
                Console.WriteLine("---------------");
            }
        }

        static void MenuHelp() {
            Console.WriteLine("\nHelp-----------------");
            Console.WriteLine("1- Cadastrar empresa:\n Você será dirigido para o tela de cadstro;");
            Console.WriteLine("2- Editar receita:\n Poderá editar a receita de uma empresa já cadastrada;");
            Console.WriteLine("3- Exibir empresas cadastradas:\n Exibe a lista de empresas cadastradas;");
            Console.WriteLine("4- Ajuda:\n Exibe a ajuda;");
            Console.WriteLine("5- Sair:\n Sair do programa;\n");

            Console.ReadLine();

            return;
        }
    }
}

using System;
using System.Collections.Generic;

namespace CadastroDeEmpresa {
    public class Menu {
        public int Op;
        //public List<int> list = new List<int>();
     
        public Menu() {
        }

        public void MenuScreen() {
            Empresa empresa = new Empresa();

            do {
                Console.WriteLine("Menu-------------------\n1- Cadastra empresa;");
                Console.WriteLine("2- Editar receita;\n3- Ajuda;\n4- Sair;");
                Console.Write("Opção desejada: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op) {
                    case 1:
                        empresa.EfetuarCadastro();
                        //list.Add();
                        break;
                    case 2:
                        Console.WriteLine(empresa);
                        break;
                    case 3:
                        MenuHelp();
                        break;                               
                }
                if(Op > 4) {
                    Console.WriteLine("\nComando Invalido;");
                }
                Console.WriteLine();
            } while (Op != 4);

            return;
        }

        public void MenuHelp() {
            Console.WriteLine("\nHelp-----------------");
            Console.WriteLine("1- Cadastrar empresa:\n Você será dirigido para o tela de cadstro;");
            Console.WriteLine("2- Editar receita:\n Poderá editar a receita de uma empresa já cadastrada;");
            Console.WriteLine("3- Ajuda:\n Exibe a ajuda;");
            Console.WriteLine("4- Sair:\n Sair do programa;\n");

            Console.ReadLine();
            
            return;
        }

        public void AddToList() {

            return;
        }
    }
}

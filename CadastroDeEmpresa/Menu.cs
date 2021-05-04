using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroDeEmpresa {
    public class Menu {
        public List<Empresa> Empresas { get; set; } = new List<Empresa>();
     
        public Menu() {
        }

        public void FindEmpresa() {
            bool Finded = false;
            Console.WriteLine("Digite o Id e o Nome da sua empresa");

            Console.Write("Digite o id da empresa: ");
            int find = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da empresa: ");
            string nome = Console.ReadLine();

            foreach(Empresa empresa in Empresas) {
                if(empresa.Id == find && empresa.Nome == nome) {
                    Finded = true;
                    //criar método ou um novo menu?
                }
            }
            if(Finded != true) {
                Console.WriteLine("Empresa não encontrada.");
                return;
            }
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

        
    }
}

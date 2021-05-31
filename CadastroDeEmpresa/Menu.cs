using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroDeEmpresa {
    public class Menu {
        public List<Empresa> Empresas { get; set; } = new List<Empresa>();
     
        public Menu() {
        }

        public void AddEmpresa(int id,string  nome,double receita) {
            Empresa empresa = new Empresa(id, nome, receita);
            Empresas.Add(empresa);
        }

        public void RemoveEmpresa(int id, string nome, double receita) {
            Empresa empresa = new Empresa(id, nome, receita);
            Empresas.Remove(empresa);
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
                    EditarReceita(find, nome);
                    return;
                }               
            }
            Console.WriteLine("Empresa não enconttrada.");         
        }  
        
        public void EditarReceita(int id, string nome) {
            Console.WriteLine("Você deseja:\n1- Adicionar Lucro;\n2- Adicionar Despeza;");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantia? R$");
            double quantia = double.Parse(Console.ReadLine());

            if (op == 1) {
                foreach(Empresa item in Empresas) {
                    if (item.Id == id && item.Nome == nome) {
                        item.AddLucro(quantia);
                    }
                }
            }
            else {
                foreach (Empresa item in Empresas) {
                    if (item.Id == id && item.Nome == nome) {
                        item.AddDespesa(quantia);
                    }
                }
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

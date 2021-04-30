using System;
using System.Globalization;

namespace CadastroDeEmpresa {
    class Empresa {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Receita { get; private set; }

        Menu main = new Menu();
       
        public Empresa() {
        }

        public void EfetuarCadastro() {
            Console.Write("Escreva o nome da empresa: ");
            Nome = Console.ReadLine();         
            
            Console.Write("Escreva o valor de receita: R$ ");
            Receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Cadastro efetuado com sucesso;\n");

            return;
        }
        public override string ToString() {
            return "Empresa: " + Nome + "\nReceita: R$" + Receita.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

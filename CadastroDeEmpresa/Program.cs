using System;

namespace CadastroDeEmpresa {
    class Program {
        static void Main(string[] args) {
            /*
             * Criar um programa que crie um cadastro de empresa com:
             * Id( de 3 númeors que não pode se repetir);
             * Nome(não pode se repetir);
             * Receita(pode ser alterada caso o usuário faça o login com o Id e o Nome);
             * E possua opção de se alterar a Receita por meio de despesas e Prejuizo e/ou Lucro;
            */
            Menu main = new Menu();

            main.MenuScreen();
            Console.ReadKey();
        }
    }
}

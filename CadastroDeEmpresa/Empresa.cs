using System;

namespace CadastroDeEmpresa {
    class Empresa {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Receita { get; private set; }

        Menu main = new Menu();
       
        public Empresa( int id, string nome, double receita) {
            Id = id;
            Nome = nome;
            Receita = receita;
        }         
    }
}

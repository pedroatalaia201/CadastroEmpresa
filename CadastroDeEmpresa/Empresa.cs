using System;

namespace CadastroDeEmpresa {
    public class Empresa {
        public int Id { get;  set; }
        public string Nome { get; set; }
        public double Receita { get;  set; }
       
        public Empresa( int id, string nome, double receita) {
            Id = id;
            Nome = nome;
            Receita = receita;
        }         
    }
}

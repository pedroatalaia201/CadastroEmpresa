using System;

namespace CadastroDeEmpresa {
    public class Empresa {
        public int Id { get;  set; }
        public string Nome { get; set; }
        public double Receita { get;  set; }

        public Empresa() {
        }
       
        public Empresa( int id, string nome, double receita) {
            Id = id;
            Nome = nome;
            Receita = receita;
        }         

        public void AddLucro(double quantia) {
            Receita += quantia;
        }

        public void AddDespesa(double quantia) {
            Receita -= quantia;            
        }
    }
}

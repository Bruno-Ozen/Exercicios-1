using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoYoutube
{
    public class Gafanhoto : Pessoa
    {
        private String login;
        private int totAssistido;

        public String Login {
            get { return this.login; }
            set { this.login = value; }
        }

        public int TotAssistido {
            get { return this.totAssistido; }
            set { this.totAssistido = value; }
        }

        public Gafanhoto(string nome, string sexo, int idade, float experiencia, string login, int totAssistido) : base(nome, sexo, idade, experiencia)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.experiencia = 0;
            this.login = login;
            this.totAssistido = totAssistido;
        }

    }
}

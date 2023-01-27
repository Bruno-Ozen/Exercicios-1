using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoYoutube
{
    public abstract class Pessoa
    {
        protected String nome;
        protected String sexo;
        protected int idade;
        protected float experiencia;

        protected Pessoa(string nome, string sexo, int idade, float experiencia)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.experiencia = 0;
        }
    }
}

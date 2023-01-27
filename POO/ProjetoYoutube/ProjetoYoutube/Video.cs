using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoYoutube
{
    public class Video : AcoesVideo
    {
        public string titulo;
        public int avaliacao;
        public int views;
        public int curtidas;
        private bool reproduzindo;
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value;  }
        }
        public int Avaliacao
        {
            get
            {
                return this.avaliacao;
            }
            set
            {
                int nova = 0;
                if (this.Views > 0)
                    nova = (this.avaliacao + value) / this.Views;
                this.avaliacao = nova;
            }
        }
        public int Views {
            get { return this.views; }
            set { this.views = value; }
        }
        public int Curtidas {
            get { return this.curtidas; }
            set { this.curtidas = value; }
        }
        public bool Reproduzindo {
            get { return this.reproduzindo; }
            set { this.reproduzindo = value; }
        }

        public Video(string titulo)
        {
            this.Titulo = titulo;
        }
        
        public void play()
        {
            this.Reproduzindo = true;
        }

        public void pause()
        {
            this.Reproduzindo = false;
        }

        public void like()
        {
            this.Curtidas++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoYoutube
{
    public class Visualizacao
    {
        public Gafanhoto espectador;
        public Video filme;
        
        public Gafanhoto Espectador
        {
            get { return espectador; } 
            set { espectador = value; }  
        }

        public Video Filme
        {
            get { return filme; }
            set { filme = value; }
        }

        public Visualizacao(Gafanhoto espectador, Video filme)
        {
            this.espectador = espectador;
            this.filme = filme;
            this.espectador.TotAssistido++;
            this.filme.Views++;
        }

        public void avaliar()
        {
            this.Filme.Avaliacao = 5;
        }

        public void avaliar(int nota)
        {
            this.Filme.Avaliacao = nota;
        }

        public void avaliar(float porc)
        {
            int tot = 0;
            if (porc <= 20)
            {
                tot = 3;
            }
            else if (porc <= 50)
            {
                tot = 5;
            }
            else if (porc <= 90)
            {
                tot = 8;
            }
            else
            {
                tot = 10;
            }
            this.Filme.Avaliacao = tot;
        }
    }
}

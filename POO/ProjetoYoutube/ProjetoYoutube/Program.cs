using ProjetoYoutube;
using System.Runtime.CompilerServices;
using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        Video video = new Video("Venoninho Extue");
        Gafanhoto gafanhoto = new Gafanhoto("Bruno", "Masculino", 18, 90.2f, "BrunoHP", 4);
        Gafanhoto gafanhoto1 = new Gafanhoto("Perenaldo", "Masculino", 42, 100f, "Perenaldo", 99);
        Visualizacao visualizacao = new Visualizacao(gafanhoto, video);
        Visualizacao visualizacao1 = new Visualizacao(gafanhoto1, video);
        visualizacao.avaliar(90);
        visualizacao1.avaliar();
        WriteLine(video.Avaliacao);
        WriteLine(video.Views);
    }
}
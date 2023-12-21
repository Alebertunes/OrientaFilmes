namespace Alura.Filmes;

class Filme
{

    public Filme(string titulo, double duracao )
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo {get;}
    public double Duracao {get; }
    private List<Artista> listaArtistas = new();

    public void ExibirFilme()
    {
        Console.WriteLine($"Titulo: {Titulo} \n Duração: {Duracao}");

    }

    public void AdicionarArtista(Artista artista)
    {
        listaArtistas.Add(artista);

    }

    public void ImprimirArtista()
    {
        foreach(Artista artista in listaArtistas)
        {
            Console.WriteLine($"Artista: {artista.Nome}");
            Console.WriteLine($"Artista: {artista.Idade}");
        }
    }
}
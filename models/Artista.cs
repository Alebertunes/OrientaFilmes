namespace Alura.Filmes;

class Artista
{

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public string Nome { get; set; }
    public int Idade { get; set; }

}
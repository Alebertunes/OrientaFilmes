using Alura.Filmes;

List<Filme> listaFilmes = new();

void Menu()
{

    Console.WriteLine("Digite a opção que deseja :");
    Console.WriteLine("1 - Cadastrar Filmes");
    Console.WriteLine("2 - Mostrar Filmes");
    Console.WriteLine("3 - Cadastrar Artista");
    Console.WriteLine("4 - Mostrar Artista");
    string opc = Console.ReadLine()!;
    int opcNum = int.Parse(opc);

    switch(opcNum)
    {
        case 1:
        CadastrarFilme();
        break;
        case 2:
        MostrarFilmes();
        break;
        case 3:
        CadastrarArtista();
        break;
        default:
        Console.WriteLine("Opção invalida");
        break;
    }
    

}

void CadastrarFilme()
{

    Console.WriteLine("Digite o nome do filme que deseja cadastrar: ");
    string nomeFilme = Console.ReadLine()!;

    Console.WriteLine("Digite a duracao do filme");
    string duracao = Console.ReadLine()!;
    double duracaoDouble = double.Parse(duracao);
    Filme filme = new(nomeFilme, duracaoDouble);
    listaFilmes.Add(filme);
    Console.WriteLine("Filme cadastrado com sucesso");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

void MostrarFilmes()
{
    Console.WriteLine("Lista de filmes cadastrados");
    
    foreach(Filme filme in listaFilmes)
    {
        filme.ExibirFilme();
        filme.ImprimirArtista();


    }

    Console.WriteLine("Digite qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void CadastrarArtista()
{
    Console.WriteLine("Digite o nome do filme que o artista participa");
    string tituloFilme = Console.ReadLine()!;

    Filme? filmeEnc = listaFilmes.Find(f => f.Titulo == tituloFilme);

    if(filmeEnc != null)
    {
        Console.WriteLine("Digite o nome do artista que deseja cadastrar: ");
        string nomeArtista = Console.ReadLine()!;
        Console.WriteLine("Digite a idade do artista");
        string idadeArtista = Console.ReadLine()!;
        int idadeArtistaInt = int.Parse(idadeArtista);

        Artista artista = new(nomeArtista, idadeArtistaInt);
        filmeEnc.AdicionarArtista(artista);
    }else
    {
        Console.WriteLine("Filme não encontrado");
    }

    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

Menu();


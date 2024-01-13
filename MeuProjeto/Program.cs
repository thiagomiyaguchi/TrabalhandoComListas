using MeuProjeto;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> listaDeAlunos = Aluno.geraAlunos();  //Chamando o método que retorna uma lista de objetos do tipo Aluno e armazenando em listaDeAlunos

        Console.WriteLine("Lista de Alunos e suas respectivas notas: \n");
        mostraAlunos(listaDeAlunos);                                              //Chamando método para mostrar alunos

        Aluno.CalculaMedia(listaDeAlunos);                                        //Chamando método que calcula a média das notas

        listaDeAlunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });             //Adicionando novos alunos
        listaDeAlunos.Add(new Aluno() { Nome = "Mario", Nota = 8.95 });

        var maioresNotas = listaDeAlunos.FindAll(n => n.Nota >= 8.0);                     // Filtrando as maiores notas
        var maioresNotasOrdenadas = maioresNotas.OrderByDescending(n => n.Nota).ToList(); //Ordenando alunos por notas
        Console.WriteLine("\nAlunos com as maiores notas: \n");
        mostraAlunos(maioresNotasOrdenadas);

    }

    public static void mostraAlunos(List<Aluno> lista)
    {
        foreach (Aluno item in lista)
        {
            Console.WriteLine($"Nome: {item.Nome}\t Nota: {item.Nota}");
        }

    }
}
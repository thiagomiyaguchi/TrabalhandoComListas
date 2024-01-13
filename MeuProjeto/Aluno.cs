namespace MeuProjeto;

internal class Aluno
{
    public string? Nome { get; set; }
    public double Nota { get; set; }

    public static List<Aluno> geraAlunos()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
           new Aluno() {Nome="Maria", Nota=8.75},
           new Aluno() {Nome="Manoel",Nota=6.95},
           new Aluno() {Nome="Amanda",Nota=7.25},
           new Aluno() {Nome="Carlos",Nota=6.55},
           new Aluno() {Nome="Jaime",Nota=8.5},
           new Aluno() {Nome="Debora",Nota=5.95},
           new Aluno() {Nome="Alicia",Nota=9.25},
           new Aluno() {Nome="Sandra",Nota=5.55},
           new Aluno() {Nome="Marta",Nota=7.85},
           new Aluno() {Nome="Sueli",Nota=9.15},
        };
        return alunos;
    }

    public static void CalculaMedia(List<Aluno> alunos)
    {
        double somaDasNotas = 0;
        foreach (Aluno item in alunos)
        {
            somaDasNotas += item.Nota;
        }
        double mediaDasNotas = somaDasNotas / alunos.Count();
        Console.WriteLine($"\nA média das notas é de: {mediaDasNotas}");
    }
}

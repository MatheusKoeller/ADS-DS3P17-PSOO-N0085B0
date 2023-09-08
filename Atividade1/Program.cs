using System;

class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }

    public Aluno(string nome, string ra)
    {
        Nome = nome;
        RA = ra;
    }

    public virtual void ValidarRA(string ra)
    {
        if (RA == ra)
        {
            Console.WriteLine($"Nome do aluno: {Nome}");
        }
        else
        {
            Console.WriteLine("RA não corresponde ao aluno.");
        }
    }
}

class AlunoComValidacao : Aluno
{
    public AlunoComValidacao(string nome, string ra) : base(nome, ra)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        AlunoComValidacao aluno = new AlunoComValidacao("Matheus Mação", "N0085B0");

        Console.Write("Digite um RA: ");
        string raDigitado = Console.ReadLine();
        aluno.ValidarRA(raDigitado);
    }
    
}
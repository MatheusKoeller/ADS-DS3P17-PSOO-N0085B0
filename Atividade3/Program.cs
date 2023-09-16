using System;

public class Pessoa
{
    private double peso;
    private double altura;

    public Pessoa(double peso, double altura)
    {
        if (altura <= 0 || peso <= 0)
        {
            throw new ArgumentException("Altura e peso devem ser valores positivos.");
        }

        this.peso = peso;
        this.altura = altura;
    }

    public double Peso
    {
        get { return peso; }
    }

    public double Altura
    {
        get { return altura; }
    }
}

public class CalculadoraIMC
{
    public double CalcularIMC(Pessoa pessoa)
    {
        double peso = pessoa.Peso;
        double altura = pessoa.Altura;

        double imc = peso / (altura * altura);
        return Math.Round(imc, 2); // Arredonda o resultado para duas casas decimais.
    }
}

public class AvaliacaoIMC
{
    public string AvaliarIMC(double imc)
    {
        if (imc <= 18.5)
        {
            return "Abaixo do normal";
        }
        else if (imc <= 24.9)
        {
            return "Peso normal";
        }
        else if (imc <= 29.9)
        {
            return "Sobrepeso";
        }
        else if (imc <= 34.9)
        {
            return "Obesidade grau I";
        }
        else if (imc <= 39.9)
        {
            return "Obesidade grau II";
        }
        else
        {
            return "Obesidade grau III";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC");
        Console.Write("Informe o peso em quilogramas: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a altura em metros Ex 1,80 : ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Pessoa pessoa = new Pessoa(peso, altura);
        CalculadoraIMC calculadora = new CalculadoraIMC();
        double imc = calculadora.CalcularIMC(pessoa);

        AvaliacaoIMC avaliacao = new AvaliacaoIMC();
        string categoriaIMC = avaliacao.AvaliarIMC(imc);

        Console.WriteLine($"Seu IMC é: {imc}");
        Console.WriteLine($"Categoria IMC: {categoriaIMC}");
    }
}

//Link para o UML https://lucid.app/lucidchart/562bb9e8-c6b6-4ddc-b358-21fc5bba4b6a/edit?invitationId=inv_9b178a32-13aa-4c55-bf80-283033023ce3
using System.Globalization;
using CadastrosBasicos.Arquivos;

namespace CadastrosBasicos.Cadastros;

public class Cliente
{
    public static void CadastrarCliente()
    {
        var culture = new CultureInfo("pt-BR");

        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("Cadastro de Cliente");
        Console.WriteLine("=============================");
        Console.WriteLine("Informe o CPF do Cliente:");
        string cpf = Console.ReadLine()!;
        
        Console.WriteLine("Informe o Nome do Cliente");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Informe a Data de Nascimento:");
        string dataNascimento = Console.ReadLine()!;
        
        var dataFormatada = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", culture);
        
        Console.WriteLine("Informe o Sexo do Cliente:");
        char sexo = char.Parse(Console.ReadLine()!);
        
        var dataCompra = DateOnly.FromDateTime(DateTime.Now);
        
        var dataCadastro = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        Console.WriteLine("Informe o Diretório que será salvo:");
        var path = Console.ReadLine()!;
        
        Diretorio.CriarDiretorio(path);
        
        Console.WriteLine($"{cpf} - {nome} - {dataFormatada.ToString("dd/MM/yyyy")!} - {sexo} - {dataCompra.ToString("dd/MM/yyyy")!} - {dataCadastro.ToString("dd/MM/yyyy")} -  {situacao}");
    }
}
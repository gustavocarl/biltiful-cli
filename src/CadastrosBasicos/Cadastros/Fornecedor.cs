using System.Globalization;
using CadastrosBasicos.Arquivos;

namespace CadastrosBasicos.Cadastros;

public class Fornecedor
{
    public static void CadastrarFornecedor()
    {
        var culture = new CultureInfo("pt-BR");
        
        Console.Clear();
        
        Console.WriteLine("=============================");
        Console.WriteLine("Cadastro de Fornecedor");
        Console.WriteLine("=============================");
        
        Console.WriteLine("Informe o CNPJ do Fornecedor:");
        string cnpj = Console.ReadLine()!;

        Console.WriteLine("Informe a Razão Social do Fornecedor:");
        string razaoSocial = Console.ReadLine()!;
        
        Console.WriteLine("Informe a Data de Abertura:");
        string dataAbertura = Console.ReadLine()!;

        var dataFormatada = DateTime.ParseExact(dataAbertura, "dd/MM/yyyy", culture);
        
        var ultimaCompra = DateOnly.FromDateTime(DateTime.Now);
        
        var dataCadastro = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';
        
        Console.WriteLine("Informe o Diretório que será salvo:");
        var path = Console.ReadLine()!;
        
        Diretorio.CriarDiretorio(path);

        Console.WriteLine($"{cnpj} - {razaoSocial} - {dataFormatada.ToString("dd/MM/yyyy")!} - {ultimaCompra.ToString("dd/MM/yyyy")} - {dataCadastro.ToString("dd/MM/yyyy")} - {situacao}");
    }
}
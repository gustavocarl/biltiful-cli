using CadastrosBasicos;
using CadastrosBasicos.Cadastros;

namespace biltiful_cli;

public class MenuFornecedor
{
    public static void MenuPrincipal()
    {
        Console.Clear();
        
        Console.WriteLine("==================================");
        Console.WriteLine("Bem-vindo ao Biltiful CLI");
        Console.WriteLine("==================================");
        Console.WriteLine("Menu Cadastros de Fornecedores");
        Console.WriteLine("==================================");
        Console.WriteLine("1 - Cadastrar Fornecedor");
        Console.WriteLine("2 - Localizar Fornecedor");
        Console.WriteLine("3 - Editar Fornecedor");
        Console.WriteLine("4 - Imprimir Registros");
        Console.WriteLine("==================================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==================================");

        string option = Console.ReadLine()!;

        switch (option)
        {
            case "0":
                MenuCadastrosBasicos.Show();
                break;
            case "1":
                Fornecedor.CadastrarFornecedor();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                MenuPrincipal();
                break;
        }
    }
}
namespace biltiful_cli;

public class MenuCadastrosBasicos
{
    public static void Show()
    {
        Console.Clear();
        
        Console.WriteLine("==================================");
        Console.WriteLine("Bem-vindo ao Biltiful CLI");
        Console.WriteLine("==================================");
        Console.WriteLine("Menu Cadastros Básicos");
        Console.WriteLine("==================================");
        Console.WriteLine("1 - Menu Cliente");
        Console.WriteLine("2 - Menu Fornecedor");
        Console.WriteLine("3 - Menu Matéria-Prima");
        Console.WriteLine("4 - Menu Produto");
        Console.WriteLine("5 - Menu Inadimplente");
        Console.WriteLine("6 - Menu Fornecedor Bloqueado");
        Console.WriteLine("==================================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==================================");

        string option = Console.ReadLine();

        
        switch (option)
        {
            case "0": 
                MenuInicial.Show();
                break;
            case "1":
                MenuCliente.MenuPrincipal();
                break;
            case "2":
                MenuFornecedor.MenuPrincipal();
                break;
            case "3":
                MenuMateriaPrima.MenuPrincipal();
                break;
            case "4":
                MenuProduto.MenuPrincipal();
                break;
            case "5":
                MenuInadimplente.MenuPrincipal();
                break;
            case "6":
                MenuFornecedorBloqueado.MenuPrincipal();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                Show();
                break;
        }
    }
}
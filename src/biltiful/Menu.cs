namespace biltiful_cli;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        
        Console.WriteLine("===========================");
        Console.WriteLine("Bem-vindo ao Biltiful CLI");
        Console.WriteLine("===========================");
        Console.WriteLine("Menu Inicial");
        Console.WriteLine("===========================");
        Console.WriteLine("1 - Cadastros Básicos");
        Console.WriteLine("2 - Venda dos Produtos");
        Console.WriteLine("3 - Compra de Matéria-Prima");
        Console.WriteLine("4 - Produção de Cosméticos");
        Console.WriteLine("===========================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("===========================");

        string option = Console.ReadLine()!;

        if (!int.TryParse(option, out int result))
            Console.WriteLine("Essa não é uma opção válida!");

        switch (result)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                MenuCadastrosBasicos.Show();
                break;
            case 2:
                Console.WriteLine("Menu Venda");
                break;
            case 3:
                Console.WriteLine("Menu Compra");
                break;
            case 4:
                Console.WriteLine("Menu Produto");
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
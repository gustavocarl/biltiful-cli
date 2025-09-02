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
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Cadastrar Fornecedor");
        Console.WriteLine("3 - Cadastrar Matéria-Prima");
        Console.WriteLine("4 - Cadastrar Produto");
        Console.WriteLine("5 - Cadastar Inadimplente");
        Console.WriteLine("6 - Cadastrar Fornecedor Bloqueado");
        Console.WriteLine("==================================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==================================");

        string option = Console.ReadLine();

        if (!int.TryParse(option, out int result))
            Console.WriteLine("Essa não é uma opção válida");


        switch (result)
        {
            case 0: 
                Menu.Show();
                break;
            case 1:
                MenuCliente.Show();
                break;
            case 2:
                MenuFornecedor.Show();
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
namespace biltiful_cli;

public class MenuProduto
{
    public static void Show()
    {
        Console.Clear();
        
        Console.WriteLine("==================================");
        Console.WriteLine("Bem-vindo ao Biltiful CLI");
        Console.WriteLine("==================================");
        Console.WriteLine("Menu Cadastros de Produtos");
        Console.WriteLine("==================================");
        Console.WriteLine("1 - Cadastrar Produto");
        Console.WriteLine("2 - Localizar Produto");
        Console.WriteLine("3 - Editar Produto");
        Console.WriteLine("4 - Imprimir Registros");
        Console.WriteLine("==================================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==================================");
    }
}
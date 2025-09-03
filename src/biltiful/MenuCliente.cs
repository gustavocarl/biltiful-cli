using CadastrosBasicos;
using CadastrosBasicos.Cadastros;

namespace biltiful_cli;

public class MenuCliente
{
    public static void MenuPrincipal()
    {
        Console.Clear();
        
        Console.WriteLine("==================================");
        Console.WriteLine("Bem-vindo ao Biltiful CLI");
        Console.WriteLine("==================================");
        Console.WriteLine("Menu Cadastros de Cliente");
        Console.WriteLine("==================================");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Localizar Cliente");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Imprimir Registros");
        Console.WriteLine("==================================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==================================");
        
        string option =  Console.ReadLine();

        switch (option)
        {
            case "0":
                MenuInicial.Show();
                break;
            case "1":
                Cliente.CadastrarCliente();
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
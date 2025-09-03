namespace CadastrosBasicos.Arquivos;

public class Diretorio
{
    public static bool CriarDiretorio(string path)
    {
        if (!Directory.Exists(path))
        {
            Console.WriteLine("Criando Diretório!");
            Directory.CreateDirectory(path);
            Console.WriteLine($"Diretório Criado com sucesso!");
            return false;
        }
        else
        {
            return true;
        }
    }
}
using System;

class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }

    public Carro(string modelo, int ano, string cor)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }

    public void Detalhes()
    {
        try
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {Cor}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao exibir detalhes do carro: {ex.Message}");
        }
    }

    public void MudarCor()
    {
        try
        {
            Console.Write("Digite a nova cor do carro: ");
            string novaCor = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(novaCor))
                throw new ArgumentException("A nova cor não pode ser vazia.");

            Cor = novaCor;
            Console.WriteLine("Cor alterada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao mudar a cor: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Criando uma instância de Carro
            Carro meuCarro = new Carro("VW Fusca", 1959, "Preto");

            // Mostrando os detalhes do carro
            Console.WriteLine("Detalhes do carro:");
            meuCarro.Detalhes();

            // Alterando a cor do carro de forma manual
            Console.WriteLine("\nAlterando a cor do carro...");
            meuCarro.MudarCor();

            // Mostrando os detalhes novamente para verificar a alteração
            Console.WriteLine("\nDetalhes atualizados do carro:");
            meuCarro.Detalhes();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no programa principal: {ex.Message}");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        /*  int raio, altura;
        double volume;
        Console.WriteLine("Informe as medidas da caixa: ");
        Console.Write("Raio: ");
        raio = int.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        altura = int.Parse(Console.ReadLine());
       // volume = Math.PI * raio * raio * altura;
        volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"Volume: {volume}");*/

        decimal pagamento, preco, troco;

        Console.WriteLine("Informe os valaores da operação");
        Console.Write("Preço:");
        preco = decimal.Parse(Console.ReadLine());
        Console.Write("Pagamento: ");
        pagamento = decimal.Parse(Console.ReadLine());

        if (pagamento >= preco)
        {
            troco = pagamento - preco;
            Console.WriteLine("Seu troco é: " + troco + "R$");
        }

        else

            Console.WriteLine("Valor insuficiente, faltou: " + (preco - pagamento));

         }
}
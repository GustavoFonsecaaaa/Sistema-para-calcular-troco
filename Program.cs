internal class Program
{
    private static void Main(string[] args)
    {
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
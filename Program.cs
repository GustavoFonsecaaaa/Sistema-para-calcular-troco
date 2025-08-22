internal class Program
{
    private static void Main(string[] args)
    {
        decimal pagamento, preco, troco, insu;

        Console.WriteLine("Informe os valaores da operação");
        Console.Write("Preço: R$");
        preco = decimal.Parse(Console.ReadLine());
        Console.Write("Pagamento: R$");
        pagamento = decimal.Parse(Console.ReadLine());

        if (pagamento >= preco)
        {
            troco = pagamento - preco;
            Console.WriteLine("Seu troco é: R$ " + troco);
        }

        else
        {
            insu = preco - pagamento;
            Console.WriteLine("Valor insuficiente, está falando: R$ " + insu);
        }
         }
}
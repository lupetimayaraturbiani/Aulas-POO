public class CaixaEletronico 
{
    Pessoa pessoa;

    public CaixaEletronico()
    {
        pessoa = new Pessoa();
    }

    public void depositarDinheiro(double valor, Pessoa pessoa)
    {
        pessoa.conta.saldo += valor;
        Console.WriteLine(pessoa.conta.saldo);
    }

    public void sacarDinheiro(double valor, Pessoa pessoa)
    {
        if (pessoa.conta.saldo < valor)
        {
            Console.WriteLine("Não há dinheiro o bastante para sacar");
        }
        pessoa.conta.saldo -= valor;
    }

    public void verificarSaldo(Pessoa pessoa)
    {
        Console.WriteLine(pessoa.conta.saldo);
    }
}

public class Pessoa 
{
    public string nome;
    public Conta conta;

    public Pessoa()
    {
        conta = new Conta(0);
    }
}

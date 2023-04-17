public class Conta
{
    int idConta;
    int agencia;
    int banco;
    double saldo;
    TipoConta tipoConta;

    public Conta(int idConta, int agencia, int banco)
    {
        this.idConta = idConta;
        this.agencia = agencia;
        this.banco = banco;
        tipoConta = TipoConta.ContaFisica;
    }

    public Conta(int idConta, int agencia, int banco, TipoConta tipoConta)
    {
        this.idConta = idConta;
        this.agencia = agencia;
        this.banco = banco;
        this.tipoConta = tipoConta;
    }
}

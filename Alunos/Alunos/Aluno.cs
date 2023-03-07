public class Aluno
{
    public int matricula;
    public string nome;
    public string nomeDisciplina;
    public double prova1;
    public double prova2;
    public double trabalho;

    public Aluno(int matricula, string nome, string nomeDisciplina, double prova1, double prova2, double trabalho)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.nomeDisciplina = nomeDisciplina;
        this.prova1 = prova1;
        this.prova2 = prova2;
        this.trabalho = prova2;
    }

    public double media()
    {
        double media = ((prova1 * 3.5) + (prova2 * 3.5) + (trabalho * 3))/10;

        return media;
    }

    public bool estaAprovado(double media)
    {
        if (media >= 6) return true;
        return false;
    }
}

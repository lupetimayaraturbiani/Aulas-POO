Aluno aluno1 = new Aluno(1, "João", "POO", 10, 6, 3);

double mediaFinal = aluno1.media();

bool foiAprovado = aluno1.estaAprovado(mediaFinal);

if (foiAprovado == true)
{
    Console.WriteLine($"O aluno {aluno1.nome} teve media {mediaFinal} e foi aprovado!");
}
else
{
    Console.WriteLine($"O aluno {aluno1.nome} teve media {mediaFinal} e não foi aprovado!");
}
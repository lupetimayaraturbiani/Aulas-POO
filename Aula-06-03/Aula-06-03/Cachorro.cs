public class Cachorro
{
    public string nome;
    public int idade;
    public string raca;
    public bool estaDormindo;

    int energia = 100;

    public Cachorro() 
    {
        this.energia = energia;
    }

    public void correr()
    {
        if(estaDormindo == false)
        {
            Console.WriteLine("Cachorro correu");
            energia -= 20;
        }
    }
}

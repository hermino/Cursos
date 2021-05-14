namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
    public Jogador(string nome)
    {
      Nome = nome;
    }
    public string Nome { get; set; }

        public void Chutar()
        {
            System.Console.WriteLine($"{Nome} está chutando");
        }
        public void Corre()
        {
            System.Console.WriteLine($"{Nome} está correndo");
        }
        public void Passe()
        {
            System.Console.WriteLine($"{Nome} está passando");
        }

    }
}
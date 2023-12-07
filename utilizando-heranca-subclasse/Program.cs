namespace utilizando_heranca_subclasse
{
    class Personagem
    {
        public string Nome { get; set; }
        public int Mana { get; set; }

        public Personagem(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }
    }

    class Subclasse : Personagem
    {
        public int DanoBase { get; set; }

        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }

        // criar personagem de subclasse
        public static void CriarSubClasseDePersonagem()
        {
            // recebe os dados de entrada
            var nome = Console.ReadLine();
            var mana = Int32.Parse(Console.ReadLine());
            var danoBase = Int32.Parse(Console.ReadLine());

            var heroiDeSubclasse = new Subclasse(nome, mana, danoBase);

            heroiDeSubclasse.CalcularDano();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Subclasse.CriarSubClasseDePersonagem();
        }
    }
}

internal class GameEngine
{
    public Player Player { get; set; }
    public Monster[] Monsters { get; set; }
    public GameEngine()
    {
        Player = new Player(1000, 50);
        Monsters = new Monster[50];
        for (int i = 1; i <50; i++)
        {
            Monsters[i - 1] = new Monster(i * 10, 10);
        }
    }

    internal void GameStart()
    {
        Player player = new Player(100, 10);
        Monster monster = new Monster(500, 4);

        for (int i = 0; i < Monsters.Length; i++)
        {
            while (Player.Hp > 0 && Monsters[i].Hp > 0)

            {
                player.Attack(Monsters[i]);
                monster.Attack(Player);


                Console.WriteLine("Výsledok boja:");
                Console.WriteLine("Player: " + Player.Hp);
                Console.WriteLine("Monster: " + Monsters[i].Hp);
                Console.WriteLine("---------------------------");
            }

            if (Player.Hp > 0)
            {
                Console.WriteLine("Hrač vyhral!");
            }

            if (Monsters[i].Hp > 0)
            {
                Console.WriteLine("Monster vyhralo!");
            }
        }
    }
    
        
}
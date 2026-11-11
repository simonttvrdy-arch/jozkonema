internal class Player
{
    public int Hp { get; set; }
    public int Damage { get; set; }
    public Player(int hp, int damage)
    {
        Hp= hp;
        Damage= damage;

    }

    internal void Attack(Monster monster)
    {
        monster.Hp -= Damage; 
    }
}
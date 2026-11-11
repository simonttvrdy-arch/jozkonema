internal class Monster
{
    public int Hp { get; set; }
    private int Damage { get; set; }

    public Monster(int hp, int damage)
    {
        Hp = hp;
        Damage = damage;
    }

    internal void Attack(Player player)
    {
        player.Hp -= Damage;
    }
}
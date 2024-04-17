namespace Danya_VS_Zondbe;

public class ZondbeCharasteristics
{
    public readonly int Hp;
    public readonly int Movement;
    public readonly int Damage;
    public readonly int Armor;
    public readonly int Award;

    public ZondbeCharasteristics(int hp, int movement, int damage, int armor, int award)
    {
        Hp = hp;
        Movement = movement;
        Damage = damage;
        Armor = armor;
        Award = award;
    }
}
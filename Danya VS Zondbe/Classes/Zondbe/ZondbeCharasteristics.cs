using System.Drawing;

namespace Danya_VS_Zondbe
{
    public class ZondbeCharasteristics
    {
        public int Hp;
        public readonly int Movement;
        public readonly int Damage;
        public readonly int Armor;
        public readonly Bitmap ZondbeImage;
        public int SkullReloadTime;

        public ZondbeCharasteristics(int hp, int movement, int damage, int armor, Bitmap zondbeImage, int skullReloadTime)
        {
            Hp = hp;
            Movement = movement;
            Damage = damage;
            Armor = armor;
            ZondbeImage = zondbeImage;
            SkullReloadTime = skullReloadTime;
        }
    }
}
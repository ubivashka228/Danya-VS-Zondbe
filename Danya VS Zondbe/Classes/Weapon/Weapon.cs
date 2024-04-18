using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Danya_VS_Zondbe
{
    public abstract class Weapon
    {
        public abstract WeaponCharasteristics CreateWeapon();
        public abstract Bullet Shot();

        public async void Reload()
        {
            await Task.Run(() => Thread.Sleep(Player.WeaponInfo.ReloadTime * 1000));
            Player.WeaponInfo.GunAmmo = Player.WeaponInfo.AmmoCapacity;
        }
    }

    public class Beretta : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(2,  10, 1);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 1, 1, 3, 600, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class DesertEagle : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(1,  5, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 5, 1, 4, 800, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class Mp5 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(10,  30, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 2, 1, 3, 800, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class Ak47 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(10,  30, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 5, 2, 4, 1000, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class Ak12 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(20,  60, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 10, 3, 4, 1100, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class Remington : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(2,  10, 1);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 6000, 100, 50, 400, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class Gau : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(40,  200, 3);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 30, 3, 5, 1200, Player.Direction, Player.Position, Color.Black);
        }
    }
    
    public class LaserMachine : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(40,  200, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 100, 100, 5, 1500, Player.Direction, Player.Position, Color.RoyalBlue);
        }
    }
    
    public class LaserBurning : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(100,  1000, 2);
        }

        public override Bullet Shot()
        {
            Player.WeaponInfo.GunAmmo--;
            return new Bullet(5000, 100, 100, 5, 1500, Player.Direction, Player.Position, Color.RoyalBlue);
        }
    }
}
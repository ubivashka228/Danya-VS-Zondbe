using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Danya_VS_Zondbe
{
    public abstract class Weapon
    {
        public abstract WeaponCharasteristics CreateWeapon();
        public abstract Bullet Shot();

        public static async void Reload()
        {
            GameModel.PlayerModel.WeaponInfo.IsReloading = true;
            await Task.Run(() => Thread.Sleep(GameModel.PlayerModel.WeaponInfo.ReloadTime * 1000));
            GameModel.PlayerModel.WeaponInfo.GunAmmo = GameModel.PlayerModel.WeaponInfo.AmmoCapacity;
            GameModel.PlayerModel.WeaponInfo.IsReloading = false;
        }
    }
    
    public class Beretta : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(10, 1);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 5, 1, 10, 600, 
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class DesertEagle : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(10, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 10, 
                1, 4, 800, GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class Mp5 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(30, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 8, 1, 3, 800, 
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class Ak47 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(30, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 15, 2, 4, 1000, 
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class Ak12 : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(60, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 20, 3, 4, 1100,
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class Remington : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(10, 1);
        }

        public override Bullet Shot()
        {
            
            return new Bullet(Color.Black, 70, 100, 20, 400, 
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class Gau : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(100, 3);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.Black, 50, 3, 5, 1200,
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class LaserMachine : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(100, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.RoyalBlue, 150, 100, 5, 1500,
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
    
    public class LaserBurning : Weapon
    {
        public override WeaponCharasteristics CreateWeapon()
        {
            return new WeaponCharasteristics(200, 2);
        }

        public override Bullet Shot()
        {
            return new Bullet(Color.RoyalBlue, 200, 100, 5, 1800,
                GameModel.PlayerModel.ShotDirection, GameModel.PlayerModel.Position);
        }
    }
}
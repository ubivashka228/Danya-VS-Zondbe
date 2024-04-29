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
            await Task.Run(() => Thread.Sleep(GameModel.PlayerModel.WeaponInfo.ReloadTime * 1000));
            GameModel.PlayerModel.WeaponInfo.GunAmmo = GameModel.PlayerModel.WeaponInfo.AmmoCapacity;
        }
    }

    public static class Drawer
    {
        public static Bitmap DrawBullet(Color color)
        {
            var bulletImage = new Bitmap(9, 9);
            using (bulletImage)
            using (var grf = Graphics.FromImage(bulletImage))
            using (var brush = new SolidBrush(color))
                grf.FillEllipse(brush, 0, 0, 10, 10);
            return bulletImage;
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 1, 1, 3, 600, 
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 5, 
                1, 4, 800, GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 2, 1, 3, 800, 
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 5, 2, 4, 1000, 
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 10, 3, 4, 1100,
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 6000, 100, 50, 400, 
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.Black), 5000, 30, 3, 5, 1200,
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.RoyalBlue), 5000, 100, 100, 5, 1500,
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
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
            GameModel.PlayerModel.WeaponInfo.GunAmmo--;
            return new Bullet(Drawer.DrawBullet(Color.RoyalBlue), 5000, 100, 100, 5, 1800,
                GameModel.PlayerModel.MoveDirection, GameModel.PlayerModel.Position);
        }
    }
}
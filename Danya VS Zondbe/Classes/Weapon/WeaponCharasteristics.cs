namespace Danya_VS_Zondbe
{
    public class WeaponCharasteristics
    {
        public readonly int FireRate;
        public int GunAmmo;
        public readonly int AmmoCapacity;
        public readonly int ReloadTime;

        public WeaponCharasteristics(int fireRate, int ammoCapacity, int reloadTime)
        {
            FireRate = fireRate;
            GunAmmo = ammoCapacity;
            AmmoCapacity = ammoCapacity;
            ReloadTime = reloadTime;
        }
    }
}
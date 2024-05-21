namespace Danya_VS_Zondbe
{
    public class WeaponCharasteristics
    {
        public int GunAmmo;
        public readonly int AmmoCapacity;
        public readonly int ReloadTime;
        public bool IsReloading;

        public WeaponCharasteristics(int ammoCapacity, int reloadTime)
        {
            GunAmmo = ammoCapacity;
            AmmoCapacity = ammoCapacity;
            ReloadTime = reloadTime;
        }
    }
}
using UnityEngine;

public class LaserWeapon : WeaponBase
{
    public override string weapon_name { get; protected set; } = "Laser";
    
    public override void StartShooting()
    {
        Debug.Log($"I am {weapon_name} and I am shooting");
    }

    public override void StopShooting()
    {
        Debug.Log($"Oh ah I, {weapon_name}, stopped shooting");
    }
}

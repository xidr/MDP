using UnityEngine;

public class ProjectileWeapon : WeaponBase
{
    public override string weapon_name { get; protected set; } = "Projectile";

    public override void StartShooting()
    {
        Debug.Log($"I am {weapon_name} and I am shooting");
    }

    public override void StopShooting()
    {
        Debug.Log($"Oh ah I, {weapon_name}, stopped shooting");
    }
}

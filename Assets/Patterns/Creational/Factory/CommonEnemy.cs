using UnityEngine;

public class CommonEnemy : EnemyBase
{
    protected override void GiveWeapon()
    {
        m_weapon = gameObject.AddComponent<ProjectileWeapon>();
    }
}

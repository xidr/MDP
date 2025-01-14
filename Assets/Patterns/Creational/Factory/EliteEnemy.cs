using UnityEngine;

public class EliteEnemy : EnemyBase
{

    protected override void GiveWeapon()
    {
        m_weapon = gameObject.AddComponent<LaserWeapon>();
    }
}

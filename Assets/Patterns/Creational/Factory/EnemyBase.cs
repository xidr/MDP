using System;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    
    protected WeaponBase m_weapon;

    private void Awake()
    {
        GiveWeapon();
        gameObject.name = GetType().ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            m_weapon.StartShooting();
    }

    protected abstract void GiveWeapon();
    
}

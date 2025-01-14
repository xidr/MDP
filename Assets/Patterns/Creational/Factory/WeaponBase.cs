using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    
    public abstract string weapon_name { get; protected set; }

    public abstract void StartShooting();
    public abstract void StopShooting();
    
}

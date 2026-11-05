using UnityEngine;
using UnityEngine.Events;
using Gamekit3D;

public class HungerGames : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DealDamage()
    {
        
        Damageable.DamageMessage specificDamageMessage = new Damageable.DamageMessage
        {
            amount = 1,
            damager = this,
            direction = Vector3.zero,
            damageSource = Vector3.zero,
            throwing = false,
            stopCamera = false,
            ;
        };
    }
}

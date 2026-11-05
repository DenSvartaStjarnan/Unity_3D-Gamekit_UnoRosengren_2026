using UnityEngine;
using UnityEngine.Events;
using Gamekit3D;

public class SurvivalMod : MonoBehaviour
{
    private Damageable damageTarget;
    
    // Timer
    [SerializeField] private float damageTime = 15.0f;
    private float timer = 0.0f;
    
    // Damage
    [SerializeField] private int damageAmount = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageTarget = GameObject.Find("Ellen").GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= damageTime)
        {
            Damageable.DamageMessage specificDamageMessage = new Damageable.DamageMessage
            {
                damager = this,
                amount = damageAmount,
                damageSource = new Vector3(0, 0, 0).normalized,
                direction = new Vector3(0, 0, 0).normalized,
                throwing = false,
                stopCamera = false
            };
            
            damageTarget.ApplyDamage(specificDamageMessage);
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timer = 0.0f;
    }
    
    private void DealDamage()
    {
        Damageable.DamageMessage specificDamageMessage = new Damageable.DamageMessage
        {
            damager = this,
            amount = 1,
            damageSource = Vector3.zero,
            direction = Vector3.zero,
            throwing = false,
            stopCamera = false
        };
        
        // Now we can use specificDamageMessage as a variable and deal 1 damage
    }
}

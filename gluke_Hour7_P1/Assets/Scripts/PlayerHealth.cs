using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 1004f;
    public float poisonDamage = 125.5f;
    // Start is called before the first frame update
    void Start()
    {
        print(health);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        RemoveHp(poisonDamage);
        print("Player has been unalived!");
    }

    void RemoveHp(float amount)
    {
        health -= amount;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

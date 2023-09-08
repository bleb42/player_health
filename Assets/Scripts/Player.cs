using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    public float Health { get; private set; }

    public void TakeDamage(float damage)
    { 
        Health -= damage;

        if (Health < 0)
            Health= 0;
        else if(Health > 1)
            Health= 1;

        StartCoroutine(_healthBar.UpdateValue());
    }
}

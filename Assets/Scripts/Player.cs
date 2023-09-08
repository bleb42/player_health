using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }

    public void TakeDamage(float damage)
    { 
        Health -= damage;

        if (Health < 0)
            Health= 0;
        else if(Health > 1)
            Health= 1;
    }

    public void Heal(float heal)
    {
        Health += heal;

        if (Health < 0)
            Health = 0;
        else if (Health > 1)
            Health = 1;
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }

    public void TakeDamage(float damage)
    { 
        Health = Mathf.Clamp(Health - damage, 0, 1);
    }

    public void Heal(float heal)
    {
        Health = Mathf.Clamp(Health + heal, 0, 1);
    }
}

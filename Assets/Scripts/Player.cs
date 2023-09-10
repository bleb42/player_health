using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _changeHealthBarValue;

    public float Health { get; private set; }

    public void TakeDamage(float damage)
    { 
        Health = Mathf.Clamp(Health - damage, 0, 1);
        _changeHealthBarValue.Invoke();
    }

    public void Heal(float heal)
    {
        Health = Mathf.Clamp(Health + heal, 0, 1);
        _changeHealthBarValue.Invoke();
    }
}

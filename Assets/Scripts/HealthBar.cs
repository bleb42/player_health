using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _damage = 0.1f;
    [SerializeField] private float _heal = 0.1f;
    [SerializeField] private float _changingTime = 2f;

    private float _playerHealth;
    private Slider _slider;

    private void Awake()
    {
        _slider= GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _playerHealth, Time.deltaTime / _changingTime);
    }

    public void Damage()
    {
        _playerHealth -= _damage;

        if (_playerHealth < 0)
        {
            _playerHealth = 0;
        }
    }

    public void Heal() 
    {
        _playerHealth += _damage;

        if (_playerHealth > 1)
        {
            _playerHealth = 1;
        }
    }
}

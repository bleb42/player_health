using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] private float _changingTime = 2f;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private IEnumerator ChangeValue()
    {
        var changingTime = new WaitForSeconds(Time.deltaTime / _changingTime);

        while (_player.Health != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, Time.deltaTime / _changingTime);

            yield return changingTime;
        }
    }

    public void UpdateValue()
    {
        StartCoroutine(ChangeValue());
    }

}

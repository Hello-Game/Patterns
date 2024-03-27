using System.Collections;
using UnityEngine;

public class WeatherInformer : MonoBehaviour
{
    private float _temperature;
    private float _windSpeed;
    private float _humidity;
    private void Start()
    {
        StartCoroutine(CheckNewWeather());
    }
    private IEnumerator CheckNewWeather()
    {
        yield return new WaitForSeconds(2f);
        _temperature = Random.Range(-30, 30);
        _humidity = Random.Range(200, 300);
        _windSpeed = Random.Range(24, 35);
    }
}

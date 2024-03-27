using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TemperatureDisplay : MonoBehaviour
{
    private float _temperature;
    private TMP_Text _text;
    private void Start()
    {
        _text = GetComponentInChildren<TMP_Text>();
    }
    public void Display()
    {
        _text.text = $"{_temperature}";
    }
}

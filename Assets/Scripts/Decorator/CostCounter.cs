using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CostCounter : MonoBehaviour
{
    Beverage coffee;
    void Start()
    {
        coffee = new HouseBlend();
        GetComponentInChildren<TMP_Text>().text = $"Стоимость кофе: {coffee.Cost} $";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    Duck duck;
    private void Start()
    {
        duck = new HarlequinDuck(gameObject);
    }
    private void Update()
    {
        if (duck != null)
        {
            duck.Swim();
        }
    }
}

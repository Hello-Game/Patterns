using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck
{
    private GameObject _duckObject;
    public Duck(GameObject duckObject)
    {
        _duckObject = duckObject;
    }
    public void Swim()
    {
        _duckObject.transform.Translate(0, 0, 1 * Time.deltaTime);
    }
}

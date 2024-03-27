using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Beverage
{
    private string _description;
    protected float _cost;
    public string Description
    {
        get { return _description; }
    }
    public float Cost
    {
        get { return _cost; }
    }
}

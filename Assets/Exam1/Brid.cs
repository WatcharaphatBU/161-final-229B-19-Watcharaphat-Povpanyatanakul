using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brid : Animal
{
    void Start()
    {
        Init("");
    }
    public override float Calculate(float food)
    {
        Debug.Log("");
        return food;
    }
    public override void MakeSound()
    {
        Debug.Log("");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public void Init(string New)
    {
        return;
    }
    public abstract float Calculate(float food);
    public virtual void MakeSound()
    {
        Debug.Log("Animal Sound");
    }
    public void DisPlayName()
    {
        
    }
}

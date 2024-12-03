using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started!");
    }
    public void Cast(string name)
    {
        Debug.Log($"Casting a Spell on target: {name}");
    }
    public void Cast(string name,int level)
    {
        Debug.Log($"Casting a Spell on {name} with level: {level}");
    }
}

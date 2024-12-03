using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Console.WriteLine("Spell-Casting Simulation Started!");
    }
    public void Cast(string name)
    {
        Console.WriteLine($"Casting a Spell on target {name}");
    }
    public void Cast(string name,int level)
    {
        Console.WriteLine($"{name}{level}");
    }
}

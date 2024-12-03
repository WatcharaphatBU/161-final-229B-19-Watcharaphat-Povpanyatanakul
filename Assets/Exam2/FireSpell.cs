using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Slime!");
        Cast("Slime!",5);
    }
    public override void Cast()
    {
        Console.WriteLine("Casting a FireSpell!");
    }
}

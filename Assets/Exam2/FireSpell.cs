using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public void Start()
    {
        Cast();
        Cast("Slime!");
        Cast("Slime!",5);
    }
    public override void Cast()
    {
        Debug.Log("Casting a Fire ball spell! Burn them all!");
    }
}

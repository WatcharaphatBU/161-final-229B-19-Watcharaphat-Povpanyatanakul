using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public void Start()
    {
        Cast();
        Cast("Gonlin!");
        Cast("Gonlin!", 10);
    }
    public override void Cast()
    {
        Debug.Log("Casting a Ice shard spell! Freeze the enemy!");
    }
}

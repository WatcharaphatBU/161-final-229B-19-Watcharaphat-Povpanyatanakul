using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpell : Spell
{
    public void Start()
    {
        Cast();
        Cast("Dark Kight!");
        Cast("Dark Kight!", 99);
    }
    public override void Cast()
    {
        Debug.Log("Casting a Summoning spell! Summon Mahoraka!");
    }
}

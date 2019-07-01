using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spellbook", menuName = "Zard/Spellbook", order = 0)]
public class Spellbook : Item
{
    public float damageMultiplier;
    public float manaMultiplier;
    public float lifetime;
}
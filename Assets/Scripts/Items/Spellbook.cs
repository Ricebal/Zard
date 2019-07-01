using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spellbook", menuName = "Zard/Spellbook", order = 0)]
public class Spellbook : ScriptableObject
{
    public string name;
    public float damageMultiplier;
    public float manaMultiplier;
    public float lifetime;

    public Sprite sprite;
}
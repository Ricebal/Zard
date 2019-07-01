using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shard", menuName = "Zard/Shard", order = 0)]
public class Shard : Item
{
    public float damage;
    public float manaCost;
    public float speed;

    public Color color;

    public override void Use()
    {
        Debug.Log("Using Shard: " + name);
    }
}

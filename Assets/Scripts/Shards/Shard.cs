using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

[CreateAssetMenu(fileName = "New Shard", menuName = "Zard/Shard", order = 0)]
public class Shard : ScriptableObject
{
    public string name;
    public float damage;
    public float manaCost;
    public float speed;

    public Sprite sprite;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rb = null;
    [SerializeField] private SpriteRenderer m_spriteRenderer = null;

    private float m_speed = 0;
    private float m_damage = 0;

    public void Initialize(Shard shard, Spellbook spellbook)
    {
        Destroy(gameObject, spellbook.lifetime);
        m_speed = shard.speed;
        m_damage = shard.damage;
        m_spriteRenderer.sprite = spellbook.sprite;
        m_spriteRenderer.color = shard.color;

        Debug.Log("Player shot spell: " + shard.name + " " + spellbook.name);

        m_rb.velocity = transform.right * m_speed;
    }
}

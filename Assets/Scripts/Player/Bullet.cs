using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rb = null;
    [SerializeField] private SpriteRenderer m_spriteRenderer = null;

    private float m_speed = 0;
    private float m_damage = 0;

    public void SetShard(Shard shard)
    {
        m_speed = shard.speed;
        m_damage = shard.damage;
        m_spriteRenderer.sprite = shard.sprite;
    }

    public void Fire()
    {
        m_rb.velocity = transform.right * m_speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject m_prefab = null;
    [SerializeField] private Transform m_shotSpawn = null;
    [SerializeField] private float m_cooldown = 1f;
    [SerializeField] private Stat m_mana = null;
    [SerializeField] private Shard m_shard = null;
    [SerializeField] private Spellbook m_spellbook = null;

    private float m_next = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > m_next && m_mana.currentValue >= 10)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        m_next = Time.time + m_cooldown;
        m_mana.Subtract(10);
        Spell spell = Instantiate(m_prefab, m_shotSpawn.position, transform.rotation).GetComponent<Spell>();
        spell.Initialize(m_shard, m_spellbook);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private Item m_item = null;
    [SerializeField] private SpriteRenderer m_spriteRenderer = null;

    private void Start()
    {
        m_spriteRenderer.sprite = m_item.sprite;
    }

    public Item Take()
    {
        Destroy(gameObject);
        return m_item;
    }
}

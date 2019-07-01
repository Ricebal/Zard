using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private Item m_item;
    [SerializeField] private Image m_image = null;

    public void AddItem(Item item)
    {
        m_item = item;
        // m_image.sprite = m_item.sprite;
        m_image.gameObject.SetActive(true);
    }

    public void Clear()
    {
        m_item = null;
        m_image.gameObject.SetActive(false);
    }
}

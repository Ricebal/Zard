using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private Transform m_itemsParent = null;

    private InventorySlot[] m_slots;

    // Start is called before the first frame update
    void Start()
    {
        m_slots = m_itemsParent.GetComponentsInChildren<InventorySlot>();
        InventoryManager.singleton.OnItemsChange += ItemUpdateHandler;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ItemUpdateHandler()
    {
        for (int i = 0; i < m_slots.Length; i++)
        {
            if (i < InventoryManager.GetItems().Count)
            {
                m_slots[i].AddItem(InventoryManager.GetByIndex(i));
            }
            else
            {
                m_slots[i].Clear();
            }
        }
    }
}

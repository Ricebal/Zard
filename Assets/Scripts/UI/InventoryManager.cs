using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager singleton;

    public delegate void OnItemsChangeDelegate();
    public event OnItemsChangeDelegate OnItemsChange;

    private List<Item> m_items = new List<Item>();

    private void Awake()
    {
        InitializeSingleton();
    }

    private void InitializeSingleton()
    {
        if (singleton != null && singleton != this)
        {
            Destroy(this);
        }
        else
        {
            singleton = this;
        }
    }

    public static void AddItem(Item item)
    {
        singleton.m_items.Add(item);
        singleton.OnItemsChange?.Invoke();
    }

    public static Item GetByIndex(int i)
    {
        return singleton.m_items[i];
    }

    public static List<Item> GetItems()
    {
        return singleton.m_items;
    }
}

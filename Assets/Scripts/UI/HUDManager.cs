using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public static HUDManager singleton;

    [SerializeField] private Stat m_health = null;
    [SerializeField] private Stat m_mana = null;
    [SerializeField] private GameObject m_inventory = null;

    private void Awake()
    {
        InitializeSingleton();
        m_health.OnStatChange += UpdateHealthHandler;
        m_mana.OnStatChange += UpdateManaHandler;
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

    private void UpdateHealthHandler()
    {
    }

    private void UpdateManaHandler()
    {
    }

    public static void ToggleInventory()
    {
        singleton.m_inventory.SetActive(!singleton.m_inventory.activeSelf);
    }
}

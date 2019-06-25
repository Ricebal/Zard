using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public static HUDManager singleton;

    [SerializeField] private Stat m_health;
    [SerializeField] private Stat m_mana;

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
}

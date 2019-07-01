using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Stat m_health = null;
    [SerializeField] private Stat m_mana = null;

    // Start is called before the first frame update
    void Start()
    {
        // Reset player stats
        m_health.Reset();
        m_mana.Reset();

    }
}

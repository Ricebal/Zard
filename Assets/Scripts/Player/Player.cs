using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Stat m_health;
    [SerializeField] private Stat m_mana;

    // Start is called before the first frame update
    void Start()
    {
        m_health.Reset();
        m_mana.Reset();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

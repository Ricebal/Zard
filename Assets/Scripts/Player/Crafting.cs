using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    private bool m_isAtBench = false;

    public void EnterBenchHandler()
    {
        m_isAtBench = true;
    }

    public void ExitBenchHandler()
    {
        m_isAtBench = false;
    }

    private void Update()
    {
        if (m_isAtBench && Input.GetButtonDown("Interact"))
        {
            Debug.Log("Interacting");
        }
    }
}

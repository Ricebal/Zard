using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    private bool m_isAtBench = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "SCBench")
        {
            m_isAtBench = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "SCBench")
        {
            m_isAtBench = false;
        }
    }

    private void Update()
    {
        if (m_isAtBench && Input.GetButtonDown("Interact"))
        {
            Debug.Log("Interacting");
        }
    }
}

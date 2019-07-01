using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            HUDManager.ToggleInventory();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Pickup")
        {
            Debug.Log("Picked up " + other.name);
            Item item = other.gameObject.GetComponent<Pickup>().Take();
            InventoryManager.AddItem(item);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public Item item;

    private Inventory inventory;

    // Use this for initialization
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void RemoveItem()
    {
        inventory.AddItem(item);
    }
}

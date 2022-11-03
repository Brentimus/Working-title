using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slots;
    public GameObject itemDisplayer { get; private set; }
    void InitializeInventory()
    {
        //slots = GameObject.Find("Slots");
        foreach (Transform item in slots.transform)
        {
            Debug.Log("231");
            item.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Inventory Items/empty_item");
            //slot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
        }
    }
    void Start()
    {
        InitializeInventory();
    }
}

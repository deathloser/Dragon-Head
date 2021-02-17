using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    //get UI panels/textboxes/dialogue Boxes
    public GameObject inventoryPanel;
    
    

    public List<GameObject> inventory;

    void Start() {
        inventory = new List<GameObject>();
        inventoryPanel.SetActive(false);
        

    }

    public void AddItem(GameObject item) {
        inventory.Add(item);
        //this works:
        //Debug.Log("You added " + item.name);
        Debug.Log(item.GetComponent<Item>().description);
        if(item.GetComponent<Weapon>() != null) {
            Debug.Log("This item is a weapon. Ammo: " + item.GetComponent<Weapon>().ammo + " Damage: " + item.GetComponent<Weapon>().damage);
            
            
        }
        DisplayItems();
    }

    void DisplayItems() {
        string itemDisplay = "Items: ";
        foreach (GameObject item in inventory)
        {
            itemDisplay += item.name + " ";
            
        }
        Debug.Log(itemDisplay);
    }

    public void UpdateInventory() {
        Debug.Log("UPDATING!!!!");
    }

    public void OpenInventoryPanel() {
        //onClick for BagButton will SetActive the Panel object
        inventoryPanel.SetActive(true);
        Debug.Log("I clicked the bag button!");

    }


}

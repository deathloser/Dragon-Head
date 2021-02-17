using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    
    [SerializeField]
    public string name, description;
    public GameObject itemObject;
    InventoryManager inventoryManager;


    void Start() {
        inventoryManager = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryManager>();
        

    }


    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("Player touched item!");
        }

        //MOVE THIS CODE TO PLAYERUI
        inventoryManager.UpdateInventory();


        inventoryManager.AddItem(this.gameObject);

        //display the inventory in console
        Debug.Log(inventoryManager.inventory.Count);
        int count = inventoryManager.inventory.Count;
        for (int i = 0; i < count; i++) {
            Debug.Log(inventoryManager.inventory[i]);

        }



        this.gameObject.SetActive(false);
        
    }
}

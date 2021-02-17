using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    float pickupRange = 3f;
    int layerMask;
    Camera cam;
    [SerializeField]
    GameObject gameController;

    ItemDatabase database;
    PlayerInventory inventory;


    void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        database = gameController.GetComponent<ItemDatabase>();
        inventory = gameController.GetComponent<PlayerInventory>();
        cam = GetComponent<Camera>();
        layerMask = LayerMask.GetMask("Pickup");

    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int[] inventory;
    public GameObject[] slot;

    void Start() {

        inventory = new int[3];
        slot = new GameObject[3];

        slot[0] = GameObject.FindGameObjectWithTag("Primary");
        slot[1] = GameObject.FindGameObjectWithTag("Secondary");
        slot[2] = GameObject.FindGameObjectWithTag("Melee");

        
    }
}

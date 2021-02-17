﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera camera;

    void Start() {

        camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


    }

    void OnGUI() {
        int size = 12;
        float posX = camera.pixelWidth/2 - size/4;
        float posY = camera.pixelHeight/2 - size/2;
        GUI.Label(new Rect(posX,posY,size,size), "*");

    }

    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            Vector3 point = new Vector3(camera.pixelWidth/2, camera.pixelHeight/2,0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                GameObject hitObject = hit.transform.gameObject;
                WanderingAI target = hitObject.GetComponent<WanderingAI>(); 

                if (target != null) {
                    target.ReactToHit();
                    Debug.Log("target hit!");
                } else {
                    StartCoroutine(SphereIndicator(hit.point));
                }

            }


        }
    }

    private IEnumerator SphereIndicator(Vector3 pos) {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }


}

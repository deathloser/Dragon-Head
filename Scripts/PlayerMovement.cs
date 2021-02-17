using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    public int speed = 6;
    public float gravity = -9.8f;
    public CharacterController controller;
    public float MoveSpeed;
    public float RotateSpeed;


    void Awake() {
    controller = GetComponent<CharacterController>();    
    }

    void Update() {
        MoveThePlayer();

        
        
    }
    void MoveThePlayer() {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed * Time.deltaTime;
        moveDirection.y = gravity;

        controller.Move(moveDirection);


    }
}

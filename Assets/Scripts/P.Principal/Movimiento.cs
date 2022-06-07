using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
        private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    public float speed = 6f;
    private float _speed;
    public float runSpeed = 10f;
    public float gravity = 20f;
    public float jumpSpeed = 8f;

    private void Awake(){
        this._speed = this.speed;
        this.controller = GetComponent<CharacterController>();
        if(this.controller == null){
            Debug.Log("CharacterController is null in MovimientoCC");
        }
    }

    private void Update(){
        if(this.controller.isGrounded){
            this.moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            // Transforms direction from local space to world space.
            this.moveDirection = this.transform.TransformDirection(this.moveDirection);
            this.moveDirection *= this._speed;
            if(Input.GetKey("space")){
                this.moveDirection.y = this.jumpSpeed;
            }
        } else {
            this.moveDirection.y -= this.gravity * Time.deltaTime; 
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            this._speed = this.runSpeed;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            this._speed = this.speed;
        }
        this.controller.Move(this.moveDirection * Time.deltaTime);
    }
}
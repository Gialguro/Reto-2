using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 20f;
    // public Animator animator;
    private void Start() {
       // animator= GetComponent<Animator>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

       // animator.SetFloat("X", horizontalInput);
       // animator.SetFloat("Y", verticalInput);
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();
        transform.position = transform.position + movement * speed * Time.deltaTime;

        if (movement != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed * Time.deltaTime);
    }

}

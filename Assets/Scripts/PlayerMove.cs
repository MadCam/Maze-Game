using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    int spd = 10;
    float gravity = 9.8f;
    private CharacterController myController;


    // Start is called before the first frame update
    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {


        // Determine how much should move in the z-direction
        Vector3 movementZ = Input.GetAxis("Horizontal") * Vector3.forward * spd * Time.deltaTime;

        // Determine how much should move in the x-direction
        Vector3 movementX = Input.GetAxis("Vertical") * Vector3.left * spd * Time.deltaTime;
        Vector3 movement = transform.TransformDirection(movementZ + movementX);
        movement.y -= gravity * Time.deltaTime;

        myController.Move(movement);
    }
    // When player enters the end game target it sets the ui text to you win
    // the targets box collider must be set as a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish") {
            GameManager.gm.winGame();
        }
    }
}

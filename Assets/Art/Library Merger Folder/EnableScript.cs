using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Disable the DoorController component attached to the same GameObject when the game starts
        this.GetComponent<DoorController>().enabled = false;
    }

    // This function is called when another collider enters the trigger collider attached to this GameObject
    void OnTriggerEnter(Collider other)
    {
	// Checking if the name of the GameObject entering the trigger is "Key_Golden"
        if(other.gameObject.name == "Key_Golden")
        {
            // Enable the DoorController component attached to the same GameObject when the "Key_Golden" enters the trigger
            this.GetComponent<DoorController>().enabled = true;
        }
        else
        {
            // Outputting a debug message indicating that a collision is not occurring
            Debug.Log("Collision is NOT happening.");
            // Outputting the name of the GameObject that collided with the trigger
            Debug.Log(other.gameObject.name);
        }        
    }
}

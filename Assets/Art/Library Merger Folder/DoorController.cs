using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Reference to the door GameObject
    public GameObject door; 
    // Rotation angles for open and close states, and speed of rotation
    public float openRot, closeRot, speed; 
    // Flag indicating if the door is opening
    public bool opening; 

    void Update()
    {
        // Get the current rotation of the door
        Vector3 currentRot = door.transform.localEulerAngles;

        // Check if the door is supposed to be opening
        if (opening)
        {
            // If the current rotation is less than the desired open rotation
            if (currentRot.y < openRot)
            {
                // Rotate the door towards the open position using Lerp for smooth transition
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
	// If the door is supposed to be closing
        else 
        {
            // If the current rotation is greater than the desired close rotation
            if (currentRot.y > closeRot)
            {
                // Rotate the door towards the close position using Lerp for smooth transition
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, closeRot, currentRot.z), speed * Time.deltaTime);
            }
        }
    }

    // Method to toggle the state of the door (open/close)
    public void ToggleDoor()
    {
        opening = !opening; // Invert the value of the opening flag
    }
}
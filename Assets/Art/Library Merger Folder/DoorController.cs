using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the rotation of a door GameObject based on whether it is supposed to be opening or closing. 
/// The Update method continuously adjusts the door's rotation towards the desired state using linear interpolation (Lerp) for smooth movement.
/// The ToggleDoor method switches the state of the door between opening and closing by toggling the opening flag.
/// </summary>
public class DoorController : MonoBehaviour
{
    /// <summary>
    /// Reference to the door GameObject.
    /// </summary>
    public GameObject door;

    /// <summary>
    /// The angle at which the door is considered fully open.
    /// </summary>
    public float openRot;

    /// <summary>
    /// The angle at which the door is considered fully closed.
    /// </summary>
    public float closeRot;

    /// <summary>
    /// The speed of door rotation.
    /// </summary>
    public float speed;

    /// <summary>
    /// Flag indicating whether the door is currently opening.
    /// </summary>
    public bool opening;

    /// <summary>
    /// Updates the door's rotation based on its opening state.
    /// </summary>
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
        else // If the door is supposed to be closing
        {
            // If the current rotation is greater than the desired close rotation
            if (currentRot.y > closeRot)
            {
                // Rotate the door towards the close position using Lerp for smooth transition
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, closeRot, currentRot.z), speed * Time.deltaTime);
            }
        }
    }

    /// <summary>
    /// Toggles the state of the door (open/close).
    /// </summary>
    public void ToggleDoor()
    {
        opening = !opening; // Invert the value of the opening flag
    }
}
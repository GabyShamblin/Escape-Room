using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHere : MonoBehaviour
{
    [SerializeField] private StartDoorOpen anim;

    /// <summary>
    /// Trigger the door open animation when the key enters the phantom key
    /// </summary>
    private void OnTriggerEnter(Collider other) {
        // Check if collided object is a key
        if (other.tag == "Key") {
            // Turn off collided key
            other.gameObject.SetActive(false);
            // Start door animation
            anim.OpenDoor();
        }
    }
}

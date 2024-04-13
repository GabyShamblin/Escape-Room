using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOfftoOn : MonoBehaviour
{
    // Reference to the parent GameObject containing the lights
    public GameObject lightParent;
    public GameObject audioSource;
    //public AudioClip audioClip;

    void Start()
    {
        // Deactivate the parent GameObject containing the lights when the game starts
        lightParent.SetActive(false);
        audioSource.SetActive(false);

    }

    // This function is called when another collider enters the trigger collider attached to this GameObject
    void OnTriggerEnter(Collider other)
    {
        // Checking if the name of the GameObject entering the trigger is "Direct Interactor"
        if (other.gameObject.name == "Direct Interactor")
        {
            // Outputting a debug message indicating that a collision is happening
            Debug.Log("Collision is happening.");
            // Activate the parent GameObject containing the lights
            lightParent.SetActive(true);
            //audioSource.PlayOneShot(audioClip);
            audioSource.SetActive(true);
        }
        else
        {
            // Outputting a debug message indicating that a collision is not happening
            Debug.Log("Collision is NOT happening.");
            // Outputting the name of the GameObject that collided with the trigger
            Debug.Log(other.gameObject.name);
        }
    }
}

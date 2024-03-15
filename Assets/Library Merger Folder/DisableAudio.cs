using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAudio : MonoBehaviour
{
    // Reference to the GameObject containing the audio component
    [SerializeField] GameObject _audio; 
    // This function is called when another collider enters the trigger collider attached to this GameObject
    void OnTriggerEnter(Collider other)
    {
	// Checking if the name of the GameObject entering the trigger is "Direct Interactor"
        if(other.gameObject.name == "Direct Interactor")
        {
	     // Disabling the GameObject containing the audio component
             _audio.SetActive(false);
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

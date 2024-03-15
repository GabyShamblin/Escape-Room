using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAppears : MonoBehaviour
{
    // Reference to the GameObject representing the key
    [SerializeField] GameObject _Key;
    // Reference to the GameObject representing the audio
    [SerializeField] GameObject _audio;

    void Start()
    {
	// Deactivates the key and audio GameObjects when the game starts
        _Key.SetActive(false);
        _audio.SetActive(false);
    }

    // This function is called when another collider enters the trigger collider attached to this GameObject
    void OnTriggerEnter(Collider other)
    {
	// Checking if the name of the GameObject entering the trigger is "Direct Interactor"
        if(other.gameObject.name == "Direct Interactor")
	{
	     // Activates the key and audio GameObjects if "Direct Interactor" enters the trigger
             _Key.SetActive(true);
             _audio.SetActive(true);
	}
	else
        {
	    // Outputs a debug message indicating that a collision is not occurring
            Debug.Log("Collision is NOT happening.");
	    // Outputs the name of the GameObject that collided with the trigger
	    Debug.Log(other.gameObject.name);
        }        
    }
    
}
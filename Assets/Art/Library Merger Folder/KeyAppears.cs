using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the appearance of a key and audio when another collider enters the trigger collider attached to this GameObject.
/// </summary>
public class KeyAppears : MonoBehaviour
{
    /// <summary>
    /// Reference to the GameObject representing the key.
    /// </summary>
    [SerializeField] GameObject _Key;

    /// <summary>
    /// Reference to the GameObject representing the audio.
    /// </summary>
    [SerializeField] GameObject _audio;

    /// <summary>
    /// Deactivates the key and audio GameObjects when the game starts.
    /// </summary>
    void Start()
    {
        // Deactivate the key and audio GameObjects when the game starts
        _Key.SetActive(false);
        _audio.SetActive(false);
    }

    /// <summary>
    /// Called when another collider enters the trigger collider attached to this GameObject.
    /// </summary>
    /// <param name="other">The collider that entered the trigger.</param>
    void OnTriggerEnter(Collider other)
    {
        // Checking if the name of the GameObject entering the trigger is "Direct Interactor"
        if (other.gameObject.name == "Direct Interactor")
        {
            // Activate the key and audio GameObjects if "Direct Interactor" enters the trigger
            _Key.SetActive(true);
            _audio.SetActive(true);
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

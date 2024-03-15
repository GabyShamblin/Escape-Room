using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the activation of lights when another collider enters the trigger collider attached to this GameObject.
/// </summary>
public class LightsOfftoOn : MonoBehaviour
{
    /// <summary>
    /// Reference to the parent GameObject containing the lights.
    /// </summary>
    [SerializeField] GameObject _lightParent;

    /// <summary>
    /// Deactivates the parent GameObject containing the lights when the game starts.
    /// </summary>
    void Start()
    {
        // Deactivate the parent GameObject containing the lights when the game starts
        _lightParent.SetActive(false);
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
            // Outputting a debug message indicating that a collision is happening
            Debug.Log("Collision is happening.");
            // Activate the parent GameObject containing the lights
            _lightParent.SetActive(true);
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

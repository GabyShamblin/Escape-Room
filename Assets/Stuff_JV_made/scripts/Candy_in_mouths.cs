using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRenderer : MonoBehaviour
{
    public GameObject Candy; // candy being inserted
    public GameObject Mouth; // mouth being inserted into
    public GameObject Hidden_Skull; // The reward for the correct insertion

    

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding objects are the right ones
        if (other.name==Mouth.name)
        {
            // Spawn the reward above the table
            Mouth.SetActive(false);
            Hidden_Skull.SetActive(true);
            Debug.Log("Correct Placement!");

        }
    }
}

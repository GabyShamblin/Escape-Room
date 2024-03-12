using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRenderer : MonoBehaviour
{
    public GameObject Candy; // candy being inserted
    public GameObject Mouth; // mouth being inserted into
    public GameObject Lit_Skull; // The reward for the correct insertion


    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding objects are the right ones
        if (other.name == Mouth.name)
        {
            Mouth.SetActive(false);
            Lit_Skull.SetActive(true);
            Debug.Log("Correct Placement!");

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Registers what mouth the candy is being slotted into
/// and on correct placement will render the skull with lit candle to
/// tell the player they have placed the correct candy
/// </summary>
public class CollisionRenderer : MonoBehaviour
{
    public GameObject Candy; // candy being inserted
    public GameObject Mouth; // mouth being inserted into
    public GameObject Lit_Skull; // The reward for the correct insertion


    private void OnTriggerEnter(Collider other)
    {

        if (other.name == Mouth.name)
        {
            Mouth.SetActive(false);
            Lit_Skull.SetActive(true);
            Debug.Log("Correct Placement!");

        }
    }
}
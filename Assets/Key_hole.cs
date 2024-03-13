using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key_hole : MonoBehaviour
{
    public GameObject Key; // candy being inserted
    public GameObject Hole; // mouth being inserted into
    public GameObject Mirror; // The reward for the correct insertion
    public GameObject Door;


    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding objects are the right ones
        if (other.name == Key.name)
        {
            Key.SetActive(false);
            Hole.SetActive(false);
            Mirror.SetActive(false);
            Door.transform.eulerAngles = new Vector3 (0,90,0); 
            Debug.Log("Correct Placement!");

        }
    }
}
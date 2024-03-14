using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Registers when the key for the basement is placed near the lock out of the basement
/// and when close enough will open the door.
/// Will also despawn the mirror in the basement to preserve system resources since the reflections
/// take a sizeable amount of computing power.
/// </summary>
public class Key_hole : MonoBehaviour
{
    public GameObject Key; 
    public GameObject Hole; 
    public GameObject Mirror;
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	this.GetComponent<DoorController>().enabled=false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Key_Golden")
	{
             this.GetComponent<DoorController>().enabled=true;
	}
	else
        {
            Debug.Log("Collision is NOT happening.");
	    Debug.Log(other.gameObject.name);
        }        
    }

}

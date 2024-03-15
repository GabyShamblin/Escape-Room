using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAudio : MonoBehaviour
{
    [SerializeField] GameObject _audio;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Direct Interactor")
	{
             _audio.SetActive(false);
	}
	else
        {
            Debug.Log("Collision is NOT happening.");
	    Debug.Log(other.gameObject.name);
        }        
    }
    
}

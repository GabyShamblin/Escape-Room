using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAppears : MonoBehaviour
{
    [SerializeField] GameObject _Key;
    [SerializeField] GameObject _audio;

    void Start()
    {
        _Key.SetActive(false);
        _audio.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Direct Interactor")
	{
             _Key.SetActive(true);
             _audio.SetActive(true);
	}
	else
        {
            Debug.Log("Collision is NOT happening.");
	    Debug.Log(other.gameObject.name);
        }        
    }
    
}
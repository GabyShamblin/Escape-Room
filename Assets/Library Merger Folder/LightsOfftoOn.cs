using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOfftoOn : MonoBehaviour
{
    [SerializeField] GameObject _lightParent;
    //[SerializeField] GameObject _globe;
    void Start()
    {
	_lightParent.SetActive(false);
        //_globe.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
       //Debug.Log(_lightParent.activeSelf);
	if(other.gameObject.name == "Direct Interactor")
	{
	     Debug.Log("Collision is happening.");
	     _lightParent.SetActive(true);
             //_globe.SetActive(true);
	}
	else
        {
            Debug.Log("Collision is NOT happening.");
	    Debug.Log(other.gameObject.name);
        }        
    }
    
}
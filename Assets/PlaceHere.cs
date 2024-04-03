using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Key") {
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Key") {
            gameObject.SetActive(false);
        }
    }
}

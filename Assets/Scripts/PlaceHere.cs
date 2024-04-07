using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHere : MonoBehaviour
{
    [SerializeField] private StartDoorOpen anim;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Key") {
            Debug.Log("Open seseame");
            other.gameObject.SetActive(false);
            anim.OpenDoor();
        }
    }
}

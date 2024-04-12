using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoorOpen : MonoBehaviour
{
    [SerializeField] private bool open = false;
    [SerializeField] private bool basement = true;
    private Animator anim;
    [SerializeField] private GameObject key;
    [SerializeField] private Material key_mat;

    /// <summary>
    /// Make sure animator and key are set
    /// </summary>
    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null) {
            Debug.LogError("Animator not found");
        }
        if (key == null) {
            Debug.LogError("Key not found");
        }
    }

    /// <summary>
    /// Manually play animation
    /// </summary>
    void Update()
    {
        if (open & anim != null) {
            OpenDoor();
            open = false;
        }
    }

    /// <summary>
    /// Play door animation
    /// </summary>
    public void OpenDoor() {
        // Set animation key to collided key
        key.GetComponent<MeshRenderer>().material = key_mat;
        // Play animation depending on what door is attatched
        if (basement) {
            anim.Play("Base Layer.Basement_Open");
        } else {
            anim.Play("Base Layer.Exit_Open");
        }
    }
}

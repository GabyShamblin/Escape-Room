using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExitOpen : MonoBehaviour
{
    [SerializeField] private bool open = false;
    private Animator anim;
    [SerializeField] private GameObject key;
    [SerializeField] private Material key_mat;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null) {
            Debug.Log("Animator not found");
        }
        if (key == null) {
            Debug.Log("Key not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (open & anim != null) {
            key.GetComponent<MeshRenderer>().material = key_mat;
            anim.Play("Base Layer.Exit_Open");
            open = false;
        }
    }
}

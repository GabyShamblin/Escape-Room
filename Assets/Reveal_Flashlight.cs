using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal_Flashlight : MonoBehaviour
{
    public GameObject Skull_l;
    public GameObject Skull_r;
    public GameObject Skull_m;
    public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Skull_l.activeSelf == true && Skull_m.activeSelf == true && Skull_r.activeSelf == true) {

            flashlight.SetActive(true);
        }

    }
}

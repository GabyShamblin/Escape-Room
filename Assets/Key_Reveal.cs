using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Reveal : MonoBehaviour
{
    public GameObject Candle_L;
    public GameObject Candle_M; 
    public GameObject Candle_R;
    public GameObject Key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Candle_L.activeSelf == true && Candle_M.activeSelf == true && Candle_R.activeSelf == true) { 
        Key.SetActive(true);
        }
    }
}
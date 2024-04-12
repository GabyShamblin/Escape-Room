using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Checks every frame if the three candle lit skulls are rendering.
/// If all three are active that means the player has completed the puzzle and then renders a lantern and the key to exit the basement.
/// </summary>
public class Key_Reveal : MonoBehaviour
{
    public GameObject Candle_L;
    public GameObject Candle_M; 
    public GameObject Candle_R;
    public GameObject Key;
    public GameObject Lantern;
    private bool activated = false;

    void Update()
    {
        if (Candle_L.activeSelf == true && Candle_M.activeSelf == true && Candle_R.activeSelf == true && !activated) { 
            Key.SetActive(true);
            Lantern.SetActive(true);
            activated = true;
        }
    }
}

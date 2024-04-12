using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines 2 method calls that toggle smoke game object for use with Unity's event system
/// </summary>
public class SmokeToggle : MonoBehaviour
{
    [SerializeField]protected GameObject _smoke;

    public void SmokeOn()
    {
        bool toggle = _smoke.activeInHierarchy;
        if(!toggle)
        {
            _smoke.SetActive(true);
        }
        
    }

    public void SmokeOff()
    {
        bool toggle = _smoke.activeInHierarchy;
        if(toggle)
        {
            _smoke.SetActive(false);
        }
    }
}

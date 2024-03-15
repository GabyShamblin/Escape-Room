using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullViewInteractionController : MonoBehaviour
{
    public GameObject viewableObject;
    public GameObject encryptedCanvas;
    public GameObject decryptedCanvas;
    public GameObject cypherSolvedCanvas;
    public GameObject orangePaint;
    public Material newMaterial;
    private GameObject _skull;
    private bool _isSolved;

    void Start()
    {
        _skull = gameObject;
        _isSolved = false;
    }

    // Check if the skull is looking in the same direction as the viewable object and mark puzzle solved if true
    void Update()
    {
        if (_isSolved) return;
        if (_skull.GetComponent<Renderer>().sharedMaterial == orangePaint.GetComponent<Renderer>().sharedMaterial 
            && InteractionHandler.AreFacingEachOther(_skull, viewableObject))
        {
            encryptedCanvas.SetActive(false);
            decryptedCanvas.SetActive(false);
            cypherSolvedCanvas.SetActive(true);

            _isSolved = true;
        }
        else
        {
            return;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manages the solve condition for the cipher puzzle involving pointing the skull at an object
/// </summary>
public class SkullViewInteractionController : MonoBehaviour
{
    public GameObject viewableObject;
    public GameObject encryptedCanvas;
    public GameObject decryptedCanvas;
    public GameObject cypherSolvedCanvas;
    public GameObject orangePaint;
    public Material newMaterial;
    public GameObject redTextCanvas;
    private GameObject _skull;
    private bool _isSolved;
    /// <summary>
    /// Initialize interactable object
    /// </summary>
    void Start()
    {
        _skull = gameObject;
        _isSolved = false;
    }

    /// <summary>
    /// Check if the skull is looking in the same direction as the viewable object and mark puzzle solved if true
    /// </summary>
    void Update()
    {
        if (_isSolved) return;
        if (_skull.GetComponent<Renderer>().sharedMaterial == orangePaint.GetComponent<Renderer>().sharedMaterial 
            && InteractionHandler.AreFacingEachOther(_skull, viewableObject))
        {
            encryptedCanvas.SetActive(false);
            decryptedCanvas.SetActive(false);
            cypherSolvedCanvas.SetActive(true);
            redTextCanvas.SetActive(true);
            _isSolved = true;
        }
        else
        {
            return;
        }
    }
}

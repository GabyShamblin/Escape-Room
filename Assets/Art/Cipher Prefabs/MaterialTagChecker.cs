using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// For the cipher board, check that material and shape match in order to mark cipher partially solved.  Once all the correct shapes and colors are on the board, the cipher is decrypted.
/// </summary>
public class MaterialTagChecker : MonoBehaviour
{
    public XRSocketInteractor socketInteractor; // Reference to the XR Socket Interactor.
    public Material correctMaterial; // The correct material to check for.
    public string correctTag; // The correct tag to check for.
    public Material newMaterial; // New material to apply if conditions are met.
    public Material defaultMaterial; // Default material to revert to.
    public TextMeshProUGUI encryptedText; // Partial encrypted text
    public TextMeshProUGUI decryptedText; // Partial decrypted text
    public AudioSource correctSoundEffect; // sound effect for getting a shape/color right
    /// <summary>
    /// intialize XR socket listeners
    /// </summary>
    void Start()
    {
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
        socketInteractor.selectExited.AddListener(OnSelectExited);
        decryptedText.enabled = false;
    }
    /// <summary>
    /// Verify that the object in the socket is the correct shape and color
    /// </summary>
    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        var interactableObject = args.interactableObject.transform.gameObject; // Get the attached object.

        if (interactableObject.CompareTag(correctTag) && interactableObject.GetComponent<Renderer>().sharedMaterial.color == correctMaterial.color)
        {
            // play sound effect
            correctSoundEffect.Play();
            
            // Change the material to the new one if they match
            interactableObject.GetComponent<Renderer>().material = newMaterial;
            encryptedText.enabled = false;
            decryptedText.enabled = true;
        }
    }
    /// <summary>
    /// Undo the color change if the object is removed from a socket
    /// </summary>
    private void OnSelectExited(SelectExitEventArgs args)
    {
        var interactableObject = args.interactableObject.transform.gameObject; // Get the detached object.
        // Change the material back to the default one.
        interactableObject.GetComponent<Renderer>().material = defaultMaterial;
        encryptedText.enabled = true;
        decryptedText.enabled = false;
    }
    /// <summary>
    /// Remove listeners to avoid memory leaks
    /// </summary>
    private void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks.
        socketInteractor.selectEntered.RemoveListener(OnSelectEntered);
        socketInteractor.selectExited.RemoveListener(OnSelectExited);
    }
}

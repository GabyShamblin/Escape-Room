using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

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
    void Start()
    {
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
        socketInteractor.selectExited.AddListener(OnSelectExited);
        decryptedText.enabled = false;
    }

    // Verify that the obejct in the socket is the correct shape and color
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

    // Undo the color change if the object is removed from a socket
    private void OnSelectExited(SelectExitEventArgs args)
    {
        var interactableObject = args.interactableObject.transform.gameObject; // Get the detached object.
        // Change the material back to the default one.
        interactableObject.GetComponent<Renderer>().material = defaultMaterial;
        encryptedText.enabled = true;
        decryptedText.enabled = false;
    }

    private void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks.
        socketInteractor.selectEntered.RemoveListener(OnSelectEntered);
        socketInteractor.selectExited.RemoveListener(OnSelectExited);
    }
}

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
    public TextMeshProUGUI encryptedText;
    public TextMeshProUGUI decryptedText;
    void Start()
    {
        // Subscribe to the select entered and exited events.
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
        socketInteractor.selectExited.AddListener(OnSelectExited);
        decryptedText.enabled = false;
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        var interactableObject = args.interactableObject.transform.gameObject; // Get the attached object.
        // Check if the object's tag and material match the correct ones.
        Debug.Log("IO - " + interactableObject.CompareTag(correctTag));
        Debug.Log("first - " + interactableObject.GetComponent<Renderer>().sharedMaterial.color);
        Debug.Log("second - " + correctMaterial.color);

        Debug.Log("mat - " + (interactableObject.GetComponent<Renderer>().sharedMaterial.color == correctMaterial.color));
        if (interactableObject.CompareTag(correctTag) && interactableObject.GetComponent<Renderer>().sharedMaterial.color == correctMaterial.color)
        {
            // Change the material to the new one.
            interactableObject.GetComponent<Renderer>().material = newMaterial;
            encryptedText.enabled = false;
            decryptedText.enabled = true;
        }
    }

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

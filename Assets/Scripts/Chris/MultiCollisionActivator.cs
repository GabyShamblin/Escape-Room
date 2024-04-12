using UnityEngine;

/// <summary>
/// Defines tag "Potions" and "Cauldron" and creates a counter that counts how often the potions collide with the cauldron.
/// If 2 objects tagged "Potions" collide with the cauldron, spawn the paint barrels, replace the empty cauldron with the full cauldron, and activate the audio clip.
/// </summary>
public class MultiCollisionActivator : MonoBehaviour
{
    [SerializeField]protected GameObject blueFill;
    [SerializeField]protected GameObject redFill;
    [SerializeField]protected GameObject paintBarrels;
    [SerializeField]protected GameObject audioSource;
    [SerializeField]protected MeshRenderer emptyCauldron;
    [SerializeField]protected MeshRenderer fullCauldron;

    public void OnCollisionEnter(Collision collision)
    {
        int collisionsDetected = 0;

        if(collision.gameObject.name == "Blue Potion")
        {
            collisionsDetected++;
            blueFill.SetActive(true);
        }

        else if(collision.gameObject.name == "Red Potion")
        {
            collisionsDetected++;
            redFill.SetActive(true);
        }

        if(collisionsDetected >= 2)
        {
            emptyCauldron.enabled = false;
            fullCauldron.enabled = true;
            audioSource.SetActive(true);
            paintBarrels.SetActive(true);
        }
    }
}
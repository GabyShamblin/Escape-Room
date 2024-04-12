using UnityEngine;

/// <summary>
/// Handles collision events between the potions and the cauldron
/// </summary>
public class MultiCollisionActivator : MonoBehaviour
{
    [SerializeField]protected GameObject blueFill;
    [SerializeField]protected GameObject redFill;
    [SerializeField]protected GameObject paintBarrels;
    [SerializeField]protected GameObject audioSource;
    [SerializeField]protected MeshRenderer emptyCauldron;
    [SerializeField]protected MeshRenderer fullCauldron;

    /// <summary>
    /// Checks to see if the item colliding with the cauldron is the red or blue potion, then activates the corresponding color and adds to the collisions detected counter.
    /// Once the counter reaches 2, the cauldron switches to the full purple cauldron, and the victory sound and paint barrels get activated. 
    /// </summary>
    /// <param name="collision"></param>
    public void OnCollisionEnter(Collision collision)
    {
        int collisionsDetected = 0;

        if(collision.gameObject.name == "Blue Potion")
        {
            collisionsDetected++;
            if(blueFill.activeSelf == false && redFill.activeSelf == false)
            {
                blueFill.SetActive(true);
            }
        }

        else if(collision.gameObject.name == "Red Potion")
        {
            collisionsDetected++;
            if(redFill.activeSelf == false && blueFill.activeSelf == false)
            {
                redFill.SetActive(true);
            }
        }

        if(collisionsDetected >= 2)
        {
            blueFill.SetActive(false);
            redFill.SetActive(false);
            emptyCauldron.enabled = false;
            fullCauldron.enabled = true;
            audioSource.SetActive(true);
            paintBarrels.SetActive(true);
        }
    }
}
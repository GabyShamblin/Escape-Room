using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

/// <summary>
/// Handles collision events between the potions and the cauldron
/// </summary>
public class MultiCollisionActivator : MonoBehaviour
{
    [SerializeField]protected GameObject paintBarrels;
    [SerializeField]protected GameObject redPotion;
    [SerializeField]protected GameObject bluePotion;
    [SerializeField]protected GameObject audioSource;
    [SerializeField]protected GameObject smoke;
    [SerializeField]protected GameObject blankCauldron;
    [SerializeField]protected MeshRenderer redCauldron;
    [SerializeField]protected MeshRenderer blueCauldron;
    [SerializeField]protected MeshRenderer purpleCauldron;
    protected int collisionsDetected = 0;

    /// <summary>
    /// Checks to see if the item colliding with the cauldron is the red or blue potion, then activates the corresponding color and adds to the collisions detected counter.
    /// Once the counter reaches 2, the cauldron switches to the full purple cauldron, and the victory sound and paint barrels get activated. 
    /// </summary>
    /// <param name="collision"></param>

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == bluePotion)
        {
            collisionsDetected++;
            bluePotion.SetActive(false);
            if(blueCauldron.enabled == false && redCauldron.enabled == false)
            {
                blankCauldron.SetActive(false);
                blueCauldron.enabled = true;
            }
        }

        else if(collision.gameObject == redPotion)
        {
            collisionsDetected++;
            redPotion.SetActive(false);
            if(redCauldron.enabled == false && blueCauldron.enabled == false)
            {
                blankCauldron.SetActive(false);
                redCauldron.enabled = true;
            }
        }

        if(collisionsDetected >= 2)
        {
            blankCauldron.SetActive(false);
            blueCauldron.enabled = false;
            redCauldron.enabled = false;
            purpleCauldron.enabled = true;
            audioSource.SetActive(true);
            paintBarrels.SetActive(true);
            smoke.SetActive(false);
        }
    }
}
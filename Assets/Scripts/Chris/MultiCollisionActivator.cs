using UnityEngine;

/// <summary>
/// Defines tag "Potions" and "Cauldron" and creates a counter that counts how often the potions collide with the cauldron.
/// If 2 objects tagged "Potions" collide with the cauldron, spawn the paint barrels.
/// </summary>
public class MultiCollisionActivator : MonoBehaviour
{
    [HideInInspector]public string collisionObjectTag = "Potions";
    [HideInInspector]public string collisionTargetTag = "Cauldron";

    private int collisionsDetected = 0;
    public GameObject redPaintBarrel;

    public GameObject orangePaintBarrel;

    public GameObject greenPaintBarrel;

    public GameObject bluePaintBarrel;
    
    //Activates an object when 3 or more collision objects collide with the target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(collisionObjectTag))
        {
            collisionsDetected++;
        }

        if (collisionsDetected >= 2)
        {
            redPaintBarrel.SetActive(true);
            orangePaintBarrel.SetActive(true);
            greenPaintBarrel.SetActive(true);
            bluePaintBarrel.SetActive(true);
        }
    }
}
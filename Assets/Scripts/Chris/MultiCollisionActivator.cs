using UnityEngine;

/// <summary>
/// Defines tag "Potions" and "Cauldron" and creates a counter that counts how often the potions collide with the cauldron.
/// If 2 objects tagged "Potions" collide with the cauldron, spawn the paint barrels, replace the empty cauldron with the full cauldron, and activate the audio clip.
/// </summary>
public class MultiCollisionActivator : MonoBehaviour
{
    [HideInInspector]public string collisionObjectTag = "Potions";
    [HideInInspector]public string collisionTargetTag = "Cauldron";

    private int collisionsDetected = 0;
    [SerializeField]protected MeshRenderer emptyCauldron;
    [SerializeField]protected MeshRenderer filledCauldron;
    public GameObject redPaintBarrel;

    public GameObject orangePaintBarrel;

    public GameObject greenPaintBarrel;

    public GameObject bluePaintBarrel;
    [SerializeField]protected GameObject _audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(collisionObjectTag))
        {
            collisionsDetected++;
        }

        if (collisionsDetected >= 2)
        {
            _audioSource.SetActive(true);
            emptyCauldron.enabled = false;
            filledCauldron.enabled = true;
            
            redPaintBarrel.SetActive(true);
            orangePaintBarrel.SetActive(true);
            greenPaintBarrel.SetActive(true);
            bluePaintBarrel.SetActive(true);
        }
    }
}
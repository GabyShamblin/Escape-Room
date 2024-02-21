using UnityEngine;

public class MultiCollisionActivator : MonoBehaviour
{
    public GameObject objectToActivate;
    public string collisionObjectTag = "CollisionObjects";
    public string collisionTargetTag = "CollisionTarget";

    private int collisionsDetected = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(collisionTargetTag))
        {
            collisionsDetected++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(collisionObjectTag))
        {
            collisionsDetected++;
        }

        if (collisionsDetected >= 3)
        {
            objectToActivate.SetActive(true);
        }
    }
}
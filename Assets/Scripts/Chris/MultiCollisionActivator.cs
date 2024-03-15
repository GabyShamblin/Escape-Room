using UnityEngine;

public class MultiCollisionActivator : MonoBehaviour
{
    public GameObject objectToActivate;
    public string collisionObjectTag = "CollisionObjects";
    public string collisionTargetTag = "CollisionTarget";

    private int collisionsDetected = 0;

    //Counts how many collision objects have collided with the target
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(collisionTargetTag))
        {
            collisionsDetected++;
        }
    }

    //Activates an object when 3 or more collision objects collide with the target
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
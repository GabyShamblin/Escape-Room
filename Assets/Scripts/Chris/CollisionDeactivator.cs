using UnityEngine;

public class CollisionDeactivator : MonoBehaviour
{
    //Object that gets deactivated
    public GameObject objectToDeactivate;

    //When the object collides with the collision target, deactivate
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CollisionTarget"))
        {
            if (objectToDeactivate != null)
            {
                objectToDeactivate.SetActive(false);
            }
        }
    }
}
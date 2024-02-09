using UnityEngine;

public class CollisionDeactivator : MonoBehaviour
{
    public GameObject objectToDeactivate;

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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// General class containing static methods for handling interactions
/// </summary>
public class InteractionHandler : MonoBehaviour
{
    /// <summary>
    /// Return true if two objects are facing eachother on the Z-axis
    /// </summary>
    public static bool AreFacingEachOther(GameObject object1, GameObject object2)
    {
        float facingThreshold = 45f;
        float distanceThreshold = 1f;
        float distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        if (object1 != null && object2 != null && distance < distanceThreshold)
        {
            Vector3 direction1 = (object2.transform.position - object1.transform.position).normalized;
            Vector3 direction2 = (object1.transform.position - object2.transform.position).normalized;

            // Calculate the angle between the forward direction of object1 and the direction to object2
            float angle1 = Vector3.Angle(object1.transform.forward, direction1);

            // Calculate the angle between the forward direction of object2 and the direction to object1
            float angle2 = Vector3.Angle(object2.transform.forward, direction2);

            // Check if both objects are facing each other within the angle threshold
            if (angle1 < facingThreshold && angle2 < facingThreshold)
            {
                return true;
            }
        }
        return false;
    }
    /// <summary>
    /// Return true if two objects are colliding
    /// </summary>
    public static bool AreColliding(GameObject object1, GameObject object2)
    {
        // Check if both objects and their colliders are not null
        if (object1 != null && object2 != null && object1.GetComponent<Collider>() != null && object2.GetComponent<Collider>() != null)
        {
            // Check for collision using the Collider component
            Collider collider1 = object1.GetComponent<Collider>();
            Collider collider2 = object2.GetComponent<Collider>();

            // Check if the colliders are overlapping
            if (collider1.bounds.Intersects(collider2.bounds))
            {
                return true;
            }
        }

        return false;
    }
}

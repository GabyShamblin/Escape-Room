using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropInteractionController : MonoBehaviour
{
    public GameObject sourceProp;
    public GameObject targetProp;

    // Start is called before the first frame update
    void Start()
    {
        InteractionHandler.AreFacingEachOther(sourceProp, targetProp);
        InteractionHandler.AreColliding(sourceProp, targetProp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

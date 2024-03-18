using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ForceCatch : MonoBehaviour
{ 
    private GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        target = other.gameObject;
        var grabInteractable = target.GetComponent<XRGrabInteractable>();

        if(grabInteractable == null)
        {
            return;
        }

        target.transform.position = gameObject.transform.position;
        target.transform.rotation = gameObject.transform.rotation;

        Destroy(target.GetComponent<XRGrabInteractable>());
        Destroy(gameObject);
    }
}

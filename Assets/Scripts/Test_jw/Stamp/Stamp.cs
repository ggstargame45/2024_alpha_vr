using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamp : MonoBehaviour
{
    private StampSign stampSign;
    public float distance = 0.2f;

    public void Call()
    {
        if (Physics.Raycast(transform.position, transform.up * -1, out RaycastHit hitInfo, distance))
        {
            stampSign = hitInfo.transform.GetComponent<StampSign>();
        }
        else
        {
            stampSign = null;
        }

        stampSign?.Stamped();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.up * -1 * distance, Color.red);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StampSign : MonoBehaviour
{
    public UnityEvent onStamped;

    public void Stamped()
    {
        onStamped?.Invoke();
    }
}

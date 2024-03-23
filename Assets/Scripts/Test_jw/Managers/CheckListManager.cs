using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckListManager : MonoBehaviour
{
    public UnityEvent awakeEvents;
    public UnityEvent startEvents;
    public UnityEvent endEvents;

    private void Awake()
    {
        awakeEvents?.Invoke();
    }

    public void On()
    {
        startEvents?.Invoke();
    }

    public void Off()
    {
        endEvents?.Invoke();
    }


}

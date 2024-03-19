using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StampWorkManager : MonoBehaviour
{
    public List<UnityEvent> events;
    int index = 0;

    private void Awake()
    {
        if (events == null)
            return;

        events[index].Invoke();
        index += 1;
    }

    public void Next()
    {
        if (events[index] == null)
        {
            End();
            return;
        }

        events[index].Invoke();
        index += 1;
    }

    private void End()
    {

    }
}

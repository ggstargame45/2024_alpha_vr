using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StampWorkManager : MonoBehaviour
{
    public List<UnityEvent> events;
    public UnityEvent endEvents;
    private int index = 0;

    private void Awake()
    {
        if (events == null)
            return;

        events[index].Invoke();
        index += 1;
    }

    public void Next()
    {
        Debug.Log(index);
        if (index >= events.Count)
        {
            End();
            return;
        }

        events[index].Invoke();
        index += 1;
    }

    private void End()
    {
        endEvents?.Invoke();
    }
}

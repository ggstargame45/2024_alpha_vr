using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlowManager : MonoBehaviour
{
    public List<UnityEvent> eventList;
    public UnityEvent endEvent;
    private int index = 0;

    private void Awake()
    {
        if (eventList.Count == 0)
        {
            return;
        }

        eventList[index].Invoke();
        index += 1;
    }

    public void Next()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }

        if (index >= eventList.Count)
        {
            End();
        }
        else
        {
            eventList[index].Invoke();
            index += 1;
        }
    }

    private void End()
    {
        endEvent?.Invoke();
    }
}

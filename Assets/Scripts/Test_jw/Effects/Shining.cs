using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shining : MonoBehaviour
{
    public Color shiningColor;
    private Renderer target;

    private void Awake()
    {
        target = GetComponent<Renderer>();
        On();
    }

    public void On()
    {
        StopAllCoroutines();
        StartCoroutine(Process());
    }

    public void Off()
    {
        StopAllCoroutines();
    }

    private IEnumerator Process()
    {
        var wfef = new WaitForEndOfFrame();
        if(target == null)
        {
            yield break;
        }
        float angle = 0f;
        while (true)
        {
            var ratio = Mathf.Abs(Mathf.Cos(angle * Mathf.Deg2Rad));
            var color = target.material.color * ratio + shiningColor * (1 - ratio);
            target.material.SetColor("_EmissionColor", color);
            angle += 0.1f;
            angle %= 360;
            yield return wfef;
        }
    }

}

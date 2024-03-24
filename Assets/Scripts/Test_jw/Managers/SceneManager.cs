using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SceneManager : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public void Call()
    {
        if(gameObjects.Count == 0)
        {
            return;
        }
        else
        {
            for(int i = 0; i < gameObjects.Count; i += 1)
            {
                Instantiate(gameObjects[i]);
            }
        }
    }
}

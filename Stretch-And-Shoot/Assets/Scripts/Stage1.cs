using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    // public int StarCount = 3;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.instance.starCount == 0)
        {
            GameManager.instance.StageClear[1] = true;
        }        
    }
}

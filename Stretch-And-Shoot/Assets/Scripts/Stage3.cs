using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    // public int StarCount = 3;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.instance.starCount == 0)
        {
            GameManager.instance.StageClear[3] = true;
        }        
    }
}

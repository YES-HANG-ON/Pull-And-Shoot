using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Destroy(gameObject);
        }
    }
}

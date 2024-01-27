using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private GameObject SelectStage;

    void Start()
    {
        SelectStage.SetActive(false);
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SelectStage.SetActive(true);
            Destroy(gameObject);
        }
    }
}

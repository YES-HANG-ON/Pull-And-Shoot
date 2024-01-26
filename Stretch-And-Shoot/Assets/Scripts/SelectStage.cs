using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Stage1;

    void Start()
    {
        Stage1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClickBtn_1()
    {
        Stage1.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_2()
    {

    }
    public void onClickBtn_3()
    {

    }
    public void onClickBtn_4()
    {

    }
    public void onClickBtn_5()
    {

    }
    public void onClickBtn_6()
    {

    }
}

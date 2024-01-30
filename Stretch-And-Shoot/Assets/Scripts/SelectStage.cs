using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] Stages = { };
    private GameObject StageInstance;

    [SerializeField]
    private GameObject[] LockedBtn = { };

    private bool[] Unlocked = {true, false, false, false, false, false, false};

    void Start()
    {
        //Stage1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= 6; i++)
        {
            if (!Unlocked[i] && GameManager.instance.StageClear[i - 1])
            {
                Unlocked[i] = true;
                Destroy(LockedBtn[i]);
            }
        }
    }

    public void onClickBtn_1()
    {
        StageInstance = Instantiate(Stages[1]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_2()
    {
        StageInstance = Instantiate(Stages[2]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_3()
    {
        StageInstance = Instantiate(Stages[3]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_4()
    {
        StageInstance = Instantiate(Stages[4]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_5()
    {
        StageInstance = Instantiate(Stages[5]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
    public void onClickBtn_6()
    {
        StageInstance = Instantiate(Stages[6]);
        GameManager.instance.starCount = 3;
        GameManager.instance.inStage = true;
        GameManager.instance.NowStage = StageInstance;
        GameManager.instance.setBall();
        StageInstance.SetActive(true);
        gameObject.SetActive(false);
    }
}

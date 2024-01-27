using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private GameObject SelectStage;

    [SerializeField]
    private GameObject ClearBtn;

    public bool isShot = false;
    public bool timeCheck = false;

    public int starCount = 0;
    public bool inStage = false;

    public float shotTime = 0f;

    [SerializeField]
    private GameObject BallPrefab;
    private GameObject BallInstance;
    public GameObject NowStage;

    public int Score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        ClearBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inStage && isShot)
        {
            shotTime = Time.time;
            isShot = false;
            timeCheck = true;
        }
        if (inStage && timeCheck && Time.time - shotTime >= 3f)
        {
            timeCheck = false;

            Destroy(BallInstance);
            BallInstance = Instantiate(BallPrefab);
        }
    }

    public void IncreaseScore()
    {
        Score++;
        if (inStage && starCount == 0)
        {
            inStage = false;
            ClearBtn.SetActive(true);
        }
    }
    public void gotoSelectStage()
    {
        ClearBtn.SetActive(false);
        SelectStage.SetActive(true);
        Destroy(NowStage);
        Destroy(BallInstance);
    }
    public void setBall()
    {
        BallInstance = Instantiate(BallPrefab);
    }
}

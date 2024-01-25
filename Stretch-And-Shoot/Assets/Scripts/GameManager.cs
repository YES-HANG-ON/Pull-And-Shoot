using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool isShot = false;
    public bool timeCheck = false;
    public float shotTime = 0f;

    [SerializeField]
    private GameObject BallPrefab;
    private GameObject BallInstance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        BallInstance = Instantiate(BallPrefab);
        print("Success");
    }

    // Update is called once per frame
    void Update()
    {
        if (isShot)
        {
            shotTime = Time.time;
            isShot = false;
            timeCheck = true;
        }
        if (timeCheck && Time.time - shotTime >= 5f)
        {
            timeCheck = false;

            Destroy(BallInstance);
            BallInstance = Instantiate(BallPrefab);
        }
    }
}

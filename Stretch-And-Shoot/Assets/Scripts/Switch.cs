using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private GameObject Wall;

    [SerializeField]
    private Sprite newSwitch;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = newSwitch;
            Destroy(Wall);
        }
    }
}

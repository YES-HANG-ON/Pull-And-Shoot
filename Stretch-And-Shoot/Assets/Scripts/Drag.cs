using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{

    private float distance = 10;
    private float initialSpeed = 0f;
    private Vector3 shootDirection = new Vector3(0f, 0f, 0f);

    [SerializeField]
    private float accelSpeed = 1f;
    
    [SerializeField]
    private LineRenderer lr;
    [SerializeField]
    private LineRenderer lr_pred;
    [SerializeField]
    private GameObject Shadow;

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        objPosition.x = Mathf.Max(objPosition.x, -2.5f);
        objPosition.x = Mathf.Min(objPosition.x, 2.5f);
        objPosition.y = Mathf.Max(objPosition.y, -4.7f);
        objPosition.y = Mathf.Min(objPosition.y, -3f);

        lr.SetPosition(1, objPosition);
        lr_pred.SetPosition(1, new Vector3(-5 * objPosition.x, -5 * (objPosition.y + 3) - 3, objPosition.z));
        transform.position = objPosition;
    }

    private void OnMouseUp()
    {
        initialSpeed = accelSpeed * Mathf.Sqrt(Mathf.Pow(transform.position.x, 2f) + Mathf.Pow(transform.position.y + 3f, 2f));
        shootDirection = new Vector3(-transform.position.x, -3 - transform.position.y, 0f).normalized;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
        rb.AddForce(shootDirection * initialSpeed, ForceMode2D.Impulse);
        lr.positionCount = 0;
        lr_pred.positionCount = 0;
        Destroy(Shadow);
        GameManager.instance.isShot = true;
    }

    void Start()
    {
        lr.positionCount = 2;
        lr_pred.positionCount = 2;
        lr.SetPosition(0, new Vector3(0f, -3f, transform.position.z));
        lr.SetPosition(1, new Vector3(0f, -3f, transform.position.z));
        lr_pred.SetPosition(0, new Vector3(0f, -3f, transform.position.z));
        lr_pred.SetPosition(1, new Vector3(0f, -3f, transform.position.z));
    }
    void Update()
    {
        // if (isShot)
        // {
        //     initialSpeed *= decSpeed * Time.deltaTime;
        //     initialSpeed = Mathf.Max(initialSpeed, 0f);
        // }
    }
}

// public class Drag : MonoBehaviour, IDragHandler
// {
//     float distance = 10.0f;
//     private Vector3 mousePosition = new Vector3(0f, 0f, 10f);
//     public void OnDrag(PointerEventData eventData)
//     {
//         Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
//         transform.position = mousePosition;
//         Debug.Log(mousePosition);
//     }

//     public void OnEndDrag(PointerEventData eventData)
//     {
//         Debug.Log(mousePosition.x);
//     }
// }
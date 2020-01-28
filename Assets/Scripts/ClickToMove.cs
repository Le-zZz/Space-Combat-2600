using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{

    [SerializeField] float speed = 1;
    private Vector3 targetPosition;
    bool isMoving = false;
    private int health = 3;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] TextMeshProUGUI P2Lives;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SetTargetPosition();
        }

        if (isMoving)
        {
            Move();
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        isMoving = true;
    }

    void Move()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }

    public void Player2Die()
    {
        health -= 1;
        String healthString = health.ToString();
        P2Lives.text = "P2 lives : " + healthString ;
        gameObject.transform.position = startPosition;
        Debug.Log("player2 Health");
        Debug.Log(health);
    }
    
    public int GetPlayer2Health()
    {
        return health;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D body;
    private Vector2 direction;

    private float speed = 3f;
    private float movementY = 0f;
    private float movementX = 0f;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] TextMeshProUGUI P1Lives;
    private int health = 3;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementY = Input.GetAxis("Vertical");
        movementX = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(movementX * speed, movementY * speed);

        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Transform>().eulerAngles += new Vector3(0, 0, 2f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Transform>().eulerAngles += new Vector3(0, 0, -2f);
        }
    }
    
    public void Player1Die()
    {
        health -= 1;
        String healthString = health.ToString();
        P1Lives.text = "P1 lives : " + healthString ;
        gameObject.transform.position = startPosition;
        Debug.Log("player2 Health");
    }

    public int GetPlayer1Health()
    {
        return health;
    }
}

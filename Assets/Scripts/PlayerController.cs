using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private Vector2 direction;

    private float speed = 1f;
    private float movement = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(movement * speed, body.velocity.y);
    }
}

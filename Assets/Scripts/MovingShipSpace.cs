using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingShipSpace : MonoBehaviour
{
    private Rigidbody2D body;
    SpriteRenderer sprite;
    [SerializeField]private Vector2 direction = new Vector2(3, 0);
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        body.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -25)
        {
            direction.x = 5;
            GetComponent<Transform>().eulerAngles += new Vector3(0, 0, 180);
        }
        else if (transform.position.x > 20)
        {
            direction.x = -5;
            GetComponent<Transform>().eulerAngles += new Vector3(0, 0, 180);
        }
    }
}

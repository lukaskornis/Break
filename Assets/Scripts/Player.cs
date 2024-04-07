using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var offset = transform.position - other.transform.position;

        if (other.gameObject.name == "Ball")
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-offset.x, 1);
        }
    }
}
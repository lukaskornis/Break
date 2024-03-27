using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1f,1f),1f);
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
}
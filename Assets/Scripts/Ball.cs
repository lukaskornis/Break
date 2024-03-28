using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed = 5;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		rb.velocity = rb.velocity.normalized * speed;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		var brick = other.gameObject.GetComponent<Brick>();

		if (brick != null)
		{
			brick.Damage();
		}
	}
}
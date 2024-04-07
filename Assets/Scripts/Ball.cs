using DG.Tweening;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed = 5;
	public Transform spawnPoint;
	Rigidbody2D rb;

	public Color normalColor;
	public Color glowColor;

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

		var sr = GetComponent<SpriteRenderer>();
		sr.DOColor(glowColor, 0.15f)
			.SetLoops(2,LoopType.Yoyo)
			.ChangeStartValue(normalColor);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		transform.position = spawnPoint.position;
		GameManager.lives--;
	}
}
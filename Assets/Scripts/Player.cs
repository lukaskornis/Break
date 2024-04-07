using DG.Tweening;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // builder pattern - per taskeli tikslinti veiksma
    }


    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        transform.DOScale(Vector3.one * 1.5f, 0.1f)
            .SetEase(Ease.Linear)
            .SetLoops(2, LoopType.Yoyo)
            .ChangeStartValue(Vector3.one);
    }
}
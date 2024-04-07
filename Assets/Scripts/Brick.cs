using DG.Tweening;
using UnityEngine;

public class Brick : MonoBehaviour
{
	 [SerializeField]int hp;
	 public int score = 100;

	 void Start()
	 {
		 transform.DOScale(Vector3.one, 1f)
			 .SetDelay(Random.Range(0f, 1f))
			 .SetEase(Ease.OutBounce)
			 .ChangeStartValue(Vector3.zero);
	 }

	 public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
	        Destroy(gameObject);
	        GameManager.score += score;
        }
    }
}
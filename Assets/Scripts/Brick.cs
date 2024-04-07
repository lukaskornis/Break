using DG.Tweening;
using UnityEngine;

public class Brick : MonoBehaviour
{
	 [SerializeField]int hp = 1;
    public int score = 100;

    void Start()
    {
	    transform.DOScale(Vector3.one, 1f)
		    .ChangeStartValue(Vector3.zero)
		    .SetDelay(Random.Range(0f, 1f))
		    .SetEase(Ease.OutElastic);

	    //transform.DORotate( new Vector3(0,0,360f),1f,RotateMode.WorldAxisAdd);
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
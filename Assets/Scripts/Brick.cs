using UnityEngine;

public class Brick : MonoBehaviour
{
	 [SerializeField]int hp = 1;
    public int score = 100;

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
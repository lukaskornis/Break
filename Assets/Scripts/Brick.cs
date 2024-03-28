using UnityEngine;

public class Brick : MonoBehaviour
{
	 [SerializeField]int hp;

    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
	        Destroy(gameObject);
        }
    }
}
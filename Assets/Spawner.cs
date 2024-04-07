using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 brickCount;
    public Vector2 brickSize = Vector2.one;
    public GameObject brickPrefab;

    void Start()
    {
        for (int y = 0; y < brickCount.y; y++)
        {
            for (int x = 0; x < brickCount.x; x++)
            {
                var pos = new Vector3(x * brickSize.x, y * brickSize.y, 0);
                Instantiate( brickPrefab, transform.position + pos, Quaternion.identity);
            }
        }
    }
}
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int lives = 3;

    public TMP_Text scoreText;
    public TMP_Text livesText;

    public GameObject winScreen;
    public GameObject loseScreen;

    void Update()
    {
        scoreText.text = "Score : " + score;
        livesText.text = "Lives : " + lives;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
        }

        
    }
}
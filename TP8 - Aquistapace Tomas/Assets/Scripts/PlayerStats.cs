using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int lifes = 3;
    public int score = 0;
    public int bricksLeft;
    public bool lose;
    public bool win;

    void Start()
    {
        score = 0;

        lose = false;
        win = false;
    }

    public void Die()
    {
        lifes--;

        if (lifes <= 0)
        {
            lose = true;

            if(GameManager.Instance.highScore < score)
            {
                GameManager.Instance.highScore = score;
            }
        }
    }

    public void EarnPoints(int amount)
    {
        score += amount;

        bricksLeft--;
        if (bricksLeft <= 0)
        {
            win = true;
            
            if (GameManager.Instance.highScore < score)
            {
                GameManager.Instance.highScore = score;
            }
        }
    }
}

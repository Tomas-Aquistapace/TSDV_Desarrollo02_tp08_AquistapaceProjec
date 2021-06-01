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

            if(GameManager.instance.highScore < score)
            {
                GameManager.instance.highScore = score;
            }
            GameManager.instance.score = score;
            GameManager.instance.finalState = false;
            this.transform.GetComponent<PlayerUI>().GoToScene();
        }
    }

    public void EarnPoints(int amount)
    {
        score += amount;

        bricksLeft--;
        if (bricksLeft <= 0)
        {
            win = true;
            
            if (GameManager.instance.highScore < score)
            {
                GameManager.instance.highScore = score;
            }
            GameManager.instance.score = score;
            GameManager.instance.finalState = true;
            this.transform.GetComponent<PlayerUI>().GoToScene();
        }
    }
}

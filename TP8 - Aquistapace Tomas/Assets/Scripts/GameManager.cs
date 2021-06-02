using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Get()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int highScore;
    public int score;
    public int totalBricks;
    public bool finalState;

    public void CheckWin(int amount)
    {
        totalBricks--;
        score += amount;
        if (totalBricks <= 0)
        {
            if (highScore < score)
            {
                highScore = score;
            }
            finalState = true;
            this.transform.GetComponent<MoveScene>().GoToScene();
        }
    }

    public void CheckEnd(int lifes)
    {
        if (lifes <= 0)
        {
            if (highScore < score)
            {
                highScore = score;
            }
            finalState = false;            
        }
    }
}

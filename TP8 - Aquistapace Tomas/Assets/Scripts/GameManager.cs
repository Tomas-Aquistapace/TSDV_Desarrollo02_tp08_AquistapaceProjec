using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public Transform player;
    public int highScore;
    public int score;
    public bool finalState;
}

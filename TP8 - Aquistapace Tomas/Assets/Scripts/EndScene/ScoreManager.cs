using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public GameObject losePoster;
    public GameObject winPoster;

    public TextMeshProUGUI highscore;
    public TextMeshProUGUI gameScore;

    void Start()
    {
        if (!GameManager.instance.finalState)
        {
            losePoster.SetActive(true);
            winPoster.SetActive(false);
        }
        else
        {
            winPoster.SetActive(true);
            losePoster.SetActive(false);
        }

        highscore.text = GameManager.instance.highScore.ToString();
        gameScore.text = GameManager.instance.score.ToString();
    }

}

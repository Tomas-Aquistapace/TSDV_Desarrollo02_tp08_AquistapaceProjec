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
        if (!GameManager.Get().finalState)
        {
            losePoster.SetActive(true);
            winPoster.SetActive(false);
        }
        else
        {
            winPoster.SetActive(true);
            losePoster.SetActive(false);
        }

        highscore.text = GameManager.Get().highScore.ToString();
        gameScore.text = GameManager.Get().score.ToString();
    }

}

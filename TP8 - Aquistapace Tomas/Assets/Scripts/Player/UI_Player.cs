using UnityEngine;
using TMPro;

public class UI_Player : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI lifes;
    public TextMeshProUGUI bricks;

    public Transform player;

    void Update()
    {
        score.text = GameManager.Get().score.ToString();
        lifes.text = player.GetComponent<PlayerStats>().lifes.ToString();
        bricks.text = GameManager.Get().totalBricks.ToString();
    }
}

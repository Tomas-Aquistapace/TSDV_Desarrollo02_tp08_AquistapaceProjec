using UnityEngine;

public class LoseLife : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameManager.Instance.player;
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Ball")
        {

            player.GetComponent<PlayerStats>().Die();
            player.GetComponent<PlayerMovement>().RestoreBallPosition();
        }
    }
}

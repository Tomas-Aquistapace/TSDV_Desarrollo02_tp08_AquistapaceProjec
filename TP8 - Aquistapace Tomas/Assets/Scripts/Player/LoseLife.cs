using UnityEngine;

public class LoseLife : MonoBehaviour
{
    public Transform player;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Ball")
        {
            player.GetComponent<PlayerStats>().Die();
            player.GetComponent<PlayerMovement>().RestoreBallPosition();
        }
    }
}

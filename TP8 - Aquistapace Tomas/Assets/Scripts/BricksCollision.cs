using UnityEngine;

public class BricksCollision : MonoBehaviour
{
    public int value = 100;

    private Transform player;

    private void Start()
    {
        player = GameManager.instance.player;
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Ball")
        {
            player.GetComponent<PlayerStats>().EarnPoints(value);

            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

public class BricksCollision : MonoBehaviour
{
    public int value = 100;

    private Transform player;

    private void Start()
    {
        //player = GameManager.Get().player;
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Ball")
        {
            GameManager.Get().CheckWin(value);

            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

public class BricksCollision : MonoBehaviour
{
    public int value = 100;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Ball")
        {
            GameManager.Get().CheckWin(value);

            Destroy(this.gameObject);
        }
    }
}

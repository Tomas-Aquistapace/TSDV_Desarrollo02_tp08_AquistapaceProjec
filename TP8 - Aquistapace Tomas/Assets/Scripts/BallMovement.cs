using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform player;
    public bool hableToMove;

    private SphereCollider sphereCollider;

    void Start()
    {
        Reposition();

        sphereCollider = transform.GetComponent<SphereCollider>();

        sphereCollider.enabled = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "LoseEdge")
        {
            player.GetComponent<PlayerStats>().Die();

            Reposition();
        }
    }

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if(hableToMove == false)
        {
            transform.position = player.position + Vector3.up;
        }
    }

    void Reposition()
    {
        transform.position = player.position + Vector3.up;

        hableToMove = false;
    }
}

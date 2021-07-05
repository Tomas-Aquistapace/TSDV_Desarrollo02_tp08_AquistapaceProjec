using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject ball;
    public float playerSpeed = 10f;
    public float ballForce = 50f;
    public bool stopBall;

    public float maxRight = 12f;
    public float minRight = 0f;

    private float initialYpos;
    private PlayerStats playerStats;

    void Start()
    {
        RestoreBallPosition();

        minRight += this.transform.localScale.x / 2;
        maxRight -= this.transform.localScale.x / 2;

        playerStats = this.transform.GetComponent<PlayerStats>();
    }

    void Update()
    {
        Movement();
        ThrowTheBall();
        InputExit();
    }

    void ThrowTheBall()
    {
        if (Input.GetKeyDown("space") && stopBall == true)
        {
            ball.transform.GetComponent<Rigidbody>().isKinematic = false;
            ball.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * ballForce);

            stopBall = false;
        }
    }

    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0, 0).normalized * playerSpeed * Time.deltaTime;

        float x = Mathf.Clamp(this.transform.position.x + direction.x, minRight, maxRight);
        float y = this.transform.position.y + direction.y;
        float z = 0;

        this.transform.position = new Vector3(x, y, z);

        if (stopBall)
        {
            ball.transform.position = new Vector3(this.transform.position.x, ball.transform.position.y, 0);
        }
    }

    void InputExit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.transform.tag == "Ball")
        {
            float x = HitPoint(coll.transform.position, this.transform.position, coll.collider.bounds.size.x);

            Vector3 newDirection = new Vector3(x, 1, 0).normalized;

            coll.transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
            coll.transform.GetComponent<Rigidbody>().AddForce(newDirection * ballForce);
        }
    }

    float HitPoint(Vector3 ballPos, Vector3 objPos, float maxWidth)
    {
        return (ballPos.x - objPos.x) / maxWidth;
    }

    public void RestoreBallPosition()
    {
        stopBall = true;
        ball.transform.GetComponent<Rigidbody>().isKinematic = true;
        initialYpos = this.transform.position.y + 0.5f;

        ball.transform.position = new Vector3(this.transform.position.x, initialYpos, 0);
    }
}

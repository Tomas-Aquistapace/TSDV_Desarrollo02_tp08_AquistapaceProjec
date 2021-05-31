using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    private float horizontal;
    private CharacterController character;
    private Vector3 direction;

    void Start()
    {
        character = transform.GetComponent<CharacterController>();

    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        direction = new Vector3(horizontal, 0, 0).normalized;

        if(direction.magnitude >= 0.1f)
        {
            character.Move(direction * playerSpeed * Time.deltaTime);
        }
    }
}

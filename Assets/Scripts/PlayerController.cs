using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpForse = 8.0F;

    private Vector2 moveDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    //CheckingGround
    private bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
        Jump();
        CheckingGround();
    }

    private void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
    }

    private void Jump()
    {
        if (Input.GetButton("Jump") && onGround)
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForse);
    }

    private void Movement()
    {
        moveDirection.x = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(moveDirection.x * speed, rigidbody.velocity.y);
    }

}

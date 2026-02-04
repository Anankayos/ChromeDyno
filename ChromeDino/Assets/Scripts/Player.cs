using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHeight = 2f;
    public Rigidbody2D rb;
    public Vector2 jumpForce;
    public bool isGrounded = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            Debug.Log("Player is grounded");
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        {
            Debug.Log("Player is not grounded");
            isGrounded = false;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           Debug.Log("Jump is " + maxHeight);
           //rb.AddForce(jumpForce);
           //rb.linearVelocity = jumpForce;
           //cinematic formula = sqrt(2 * gravity * height)
           rb.linearVelocity = Mathf.Sqrt(2f * maxHeight * Physics2D.gravity.magnitude * rb.gravityScale) * Vector2.up;

       } 
       else
       {
           Debug.Log("No Jump");
       }
    }
}

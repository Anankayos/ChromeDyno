using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    //VALUES
    public float maxHeight = 2f;
    public float maxHeightInAir = 1f;
    public bool isGrounded = true;
    //REFERENCES 
    public Rigidbody2D rb;
    public Vector2 jumpForce;
    public GameManager gameManager;
    public UnityEvent GameOver;
    public UnityEvent RestartGame;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
           // Debug.Log("Player is grounded");
            isGrounded = true;
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                GameOver.Invoke();
                Debug.Log("Game Over");
                RestartGame.Invoke();
                Debug.Log("Restart Game");
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        {
           // Debug.Log("Player is not grounded");
            isGrounded = false;
        }
    }
    // void Jump()
    //{
    //      rb.linearVelocity = Mathf.Sqrt(2f * maxHeight * Physics2D.gravity.magnitude * rb.gravityScale) * Vector2.up; 
    //zz   }
       void Jump(float height)
       {
          rb.linearVelocity = Mathf.Sqrt(2f * height * Physics2D.gravity.magnitude * rb.gravityScale) * Vector2.up; 
       }
       // Function that adds two integers and returns the result, no voidc
    //   int Sum (int a , int b)
    //    {
    //       return a + b;
    //    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
     {
    //     Debug.Log(Sum(5, 3));
    //     Debug.Log( Sum(2, 4));
    //     Debug.Log(Sum(50, 30));   
     }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
          // Debug.Log("Jump is " + maxHeight);
           //rb.AddForce(jumpForce);
           //rb.linearVelocity = jumpForce;
           //cinematic formula = sqrt(2 * gravity * height)
           Jump(maxHeight);
       } 
       else
       {
           //Debug.Log("No Jump");
       }
    //    Air Jump
    //    if (Input.GetKeyDown(KeyCode.Space) && !isGrounded)
    //    {
    //        Debug.Log("Jump is " + maxHeightInAir);
    //        Jump(maxHeightInAir);
    //    } 
    //      else
    //      {
    //           Debug.Log("No Jump");
    //      }
    }
}

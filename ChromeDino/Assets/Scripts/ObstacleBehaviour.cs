
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float speed;
    public GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = gameManager.gameSpeed;
        transform.position += speed * Time.deltaTime * Vector3.left;
        
    }
}

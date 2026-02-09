using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    Transform objectToDestroy = collision.transform.parent;
    Destroy(objectToDestroy.gameObject);
    
    }

}

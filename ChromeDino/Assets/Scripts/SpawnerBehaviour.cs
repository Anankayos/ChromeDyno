using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject [] obstaclePrefab;
    public GameManager gameManager;
    public float spawnTime = 2f;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
         GameObject obstacle;
         obstacle = GameObject.Instantiate(obstaclePrefab[0], transform);
         //int randomIndex = Random.Range(0, obstaclePrefab.Length);
         obstacle.GetComponent<ObstacleBehaviour>().gameManager = gameManager; 
         obstacle.transform.position = transform.position;
         timer += spawnTime;
        }
     
    }
}

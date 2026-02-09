using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
   // public GameObject [] obstaclePrefab;
    public SpawnerData [] spawnerDatas;
    public GameManager gameManager;
    public float spawnTime = 2f;
    public int scriptableIndex;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* The spawner has a countdown
        *1. First thing we will let the countdown to continue
        *2. Then we will check if the countdown is finished and create an obstacle if it is ended.
        * Connect the obstacle generated with the GameManager(for speed value)
        */
        // I need to know what is the current scriptable object 
           //I take the current scriptable object from the pool
           //I choose an element from the list of the current scriptable object
           //I create the obstacle, I position it and assign reference to the Game Manager
           // Choode a reandom vlaue between min/max cooldown of the scriptable and reset the time with that value
           //I reset the timer countdown
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
           //Take the current scriptable object (at the beginning is by default the scriptable at index 0 of spawnerDatas)
           //Take the treshold value from the current scriptable 
           //if it is >= treshold value, then I take the next scriptable object in the pool and assign it as current scriptable object
            if (spawnerDatas[scriptableIndex].timeTreshold <= gameManager.gameTime) // If inex == arrey spaener data (-1) ignore this if.
            {
                if (scriptableIndex < spawnerDatas.Length - 1)
                {
                   scriptableIndex++; 
                }
                
            }
                //Debug.Log(scriptableIndex);
          //int randomIndex = Random.Range(0, obstaclePrefab.Length);
            CreateObstacle(PickRandomIndexFromArray());
            ResetTimerCountdown();
        }
    }
        public void CreateObstacle(int obstacleIndex)
        {
         // Take a number between position 0 and the length of the array of obstacles to create a random obstacle
         GameObject obstacle;
         // Create obstacle
         obstacle = GameObject.Instantiate(spawnerDatas[scriptableIndex].obstacles[obstacleIndex], transform);
         //int randomIndex = Random.Range(0, obstaclePrefab.Length);
         // Positioning of the obstacle on Spawner position
         obstacle.GetComponent<ObstacleBehaviour>().gameManager = gameManager; 
         obstacle.transform.position = transform.position;
         timer += spawnTime;
        }
        public int PickRandomIndexFromArray()
        {
            return Random.Range(0, spawnerDatas[scriptableIndex].obstacles.Length);
        }
      private void ResetTimerCountdown()
        {
         float newCooldown = Random.Range(spawnerDatas[scriptableIndex].minCooldown, spawnerDatas[scriptableIndex].maxCooldown);
        // Reset countdown
        timer += newCooldown;
        Debug.Log(timer);
        }
}

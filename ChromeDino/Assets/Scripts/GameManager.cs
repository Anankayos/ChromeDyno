using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameManager : MonoBehaviour
{
    public float gameSpeed = 5f;
    public AnimationCurve speedCurve;
    public float gameTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        gameSpeed = speedCurve.Evaluate(gameTime);
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }
     
     public void GameOver()
     {
         Time.timeScale = 0f;
     }
     public void RestartGame()
     {
         SceneManager.LoadScene(0);
         Time.timeScale = 1f;
         gameTime = 0f;
     }
}

using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerData", menuName = "Scriptable Objects/SpawnerData")]
public class SpawnerData : ScriptableObject
{
    public float minCooldown, maxCooldown;
    public GameObject[] obstacles;
    public float timeTreshold;
}


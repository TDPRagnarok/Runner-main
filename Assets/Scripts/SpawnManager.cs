using Unity.Hierarchy;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnLocation = new(40, 0, 0);
    float spawnDelay = 2;
    float repeatRate = 2;
    
    public PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        if(!playerControllerScript.gameOver)
            Instantiate(obstaclePrefab, spawnLocation, obstaclePrefab.transform.rotation);
    }
}

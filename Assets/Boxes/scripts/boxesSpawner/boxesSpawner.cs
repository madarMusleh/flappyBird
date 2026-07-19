using UnityEngine;

public class boxesSpawner : MonoBehaviour
{
    public GameObject boxes;
    
    public float spawnRate = 1.5f; 
    
    public float heightOffset = 3f; 
    
    private float _timer;
    
    void Start()
    {
        Spawner();
    }
    
    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            Spawner();
            _timer = 0f;
        }
    }

    void Spawner()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        Instantiate(boxes, spawnPosition, Quaternion.identity);
    }
}

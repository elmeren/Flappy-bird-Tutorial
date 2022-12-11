using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float maxTimeBetweenPipes;
    [SerializeField] float minTimeBetweenPipes;
    private float timeBetweenCounter;


    private void Update()
    {
        if (timeBetweenCounter <= 0)
        {
            timeBetweenCounter = Random.Range(minTimeBetweenPipes, maxTimeBetweenPipes);

            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + Random.Range(2, 8));

            GameObject pipeCopy = Instantiate(pipePrefab);
            pipeCopy.transform.position = spawnPosition;
        }
        else
        {
            timeBetweenCounter -= Time.deltaTime;
        }
    }
}

using System.Threading;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float secondsBetweenSpawns = 1f;
    [SerializeField] float heightOffset = 7f;
    private bool isSpawning = true;

    void Start()
    {
        SpawnRoutine();
        Debug.Log("Start finished");
    }

    async void SpawnRoutine()
    {
        while (isSpawning)
        {
            float minPoint = transform.position.y - heightOffset;
            float maxPoint = transform.position.y + heightOffset;

            Vector3 newPosition = new Vector3(transform.position.x, Random.Range(minPoint, maxPoint), transform.position.z);

            GameObject newObject = Instantiate(pipe, newPosition, transform.rotation);
            await Awaitable.WaitForSecondsAsync(secondsBetweenSpawns);
        }
    }

    void OnDestroy()
    {
        // Stop the async task if the object is destroyed
        isSpawning = false;
    }
}
using UnityEngine;

public class BuildSpawnerScript : MonoBehaviour
{
    public GameObject buildingPrefab; // Assign the building prefab in the inspector
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnBuild();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBuild();
            timer = 0;
        }
    }

    public void spawnBuild()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;

        Instantiate(buildingPrefab, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}

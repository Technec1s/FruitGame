using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    private float spawnCooldown = 0.5f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timer >= spawnCooldown)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.y = 3;
            mousePosition.z = 0;

            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            GameObject objectToInstantiate = objectsToSpawn[randomIndex];
            Instantiate(objectToInstantiate, mousePosition, Quaternion.identity);

            timer = 0f;
        }
    }
}

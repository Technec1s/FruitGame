using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruit : MonoBehaviour
{
    public bool doNothing;
    public GameObject spawnPrefab;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(2);
        }
        else if (doNothing || !IsSameType(col.gameObject))
        {
            return;
        }

        col.gameObject.GetComponent<Fruit>().doNothing = true;
        Destroy(col.gameObject);

        Instantiate(spawnPrefab, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    bool IsSameType(GameObject otherObject)
    {
        return gameObject.tag == otherObject.tag;
    }
}

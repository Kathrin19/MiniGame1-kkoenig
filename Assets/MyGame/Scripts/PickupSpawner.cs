using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public Flower flowerPrefab;
    public Bomb bombPrefab;
    public GameObject bombParent;
    public GameObject flowerParent;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnFlower();
            SpawnBomb();
        }

    }

    private void SpawnFlower()
    {
        Flower flowerClone = (Flower)Instantiate(flowerPrefab, transform.position, transform.rotation);
        float flowerSize = 0.05f;
        flowerClone.transform.SetParent(flowerParent.transform);
        flowerClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-6f, 6f), flowerParent.transform.position.y, 0f);
        flowerClone.transform.localScale = new Vector3(flowerSize, flowerSize, 0);
        flowerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), Random.Range(-10, -1));
    }

    private void SpawnBomb()
    {
        Bomb bombClone = (Bomb)Instantiate(bombPrefab, transform.position, transform.rotation);
        float bombSize = 0.05f;
        bombClone.transform.SetParent(bombParent.transform);
        bombClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-6f, 6f), bombParent.transform.position.y, 0f);
        bombClone.transform.localScale = new Vector3(bombSize, bombSize, 0);
        bombClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), Random.Range(-10, -1));
    }
}

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
        float flowerSize = 0.07f;
        flowerClone.transform.SetParent(flowerParent.transform);
        flowerClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flowerParent.transform.position.y, 0f);
        flowerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-6, -3));
    }

    private void SpawnBomb()
    {
        Bomb bombClone = (Bomb)Instantiate(bombPrefab, transform.position, transform.rotation);
        float bombSize = 0.03f;
        bombClone.transform.SetParent(bombParent.transform);
        bombClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), bombParent.transform.position.y, 0f);
        bombClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-6, -3));
    }
}

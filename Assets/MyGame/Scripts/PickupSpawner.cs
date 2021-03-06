﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public Flower flowerPrefab;
    public Flower2 flower2Prefab;
    public Flower3 flower3Prefab;
    public Bomb bombPrefab;
    public GameObject bombParent;
    public GameObject flowerParent;
    public GameObject flower2Parent;
    public GameObject flower3Parent;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
            SpawnFlower();
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
            SpawnFlower3();
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
            SpawnFlower2();
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
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

    private void SpawnFlower2()
    {
        Flower2 flower2Clone = (Flower2)Instantiate(flower2Prefab, transform.position, transform.rotation);
        float flower2Size = 0.07f;
        flower2Clone.transform.SetParent(flower2Parent.transform);
        flower2Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flowerParent.transform.position.y, 0f);
        flower2Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-6, -3));
    }

    private void SpawnFlower3()
    {
        Flower3 flower3Clone = (Flower3)Instantiate(flower3Prefab, transform.position, transform.rotation);
        float flower3Size = 0.07f;
        flower3Clone.transform.SetParent(flower3Parent.transform);
        flower3Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flower3Parent.transform.position.y, 0f);
        flower3Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-6, -3));
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

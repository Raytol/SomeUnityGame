using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntities : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            int addXPos = Random.Range(-5, 5);
            int addZPos = Random.Range(-5, 5);
            Vector3 spawnPos = transform.position + new Vector3(addXPos, 100, addZPos);
            Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }
}

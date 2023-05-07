using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreativeC : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] spawnPositions;
    public GameObject[] codePrefabs;
    public Transform parentObj;

    void Start()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            GameObject prefabToSpawn = codePrefabs[i];
            Transform spawnPosition = spawnPositions[i];

            GameObject codePrefab = Instantiate(codePrefabs[i], spawnPositions[i].position, spawnPositions[i].rotation, parentObj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

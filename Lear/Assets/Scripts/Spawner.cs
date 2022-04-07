using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Update()
    {
        SpawnElements(_template, _spawnPoints);
    }
    private void SpawnElements(GameObject template, Transform[] spawnpoints)
    {
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            Instantiate(template, spawnpoints[i].position, Quaternion.identity);
        }
    }
}

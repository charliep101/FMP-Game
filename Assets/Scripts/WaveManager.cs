using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private float timeBetweenWaves = 3f;
    [SerializeField] private float enemyMult;

    [Space]

    [SerializeField] private float radius = 5f;
    [SerializeField] private float innerRadius = 4f;
    [SerializeField] private Vector3 originPoint = Vector3.zero;

    [Header("Components")]

    [SerializeField] GameObject enemy;

    [Header("Debug")]

    public int waveCount = 1;
    [SerializeField] public float checkIntervals = 2;
    [SerializeField] private bool drawGizmos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnWave()
    {
        for(int i = 0; i < waveCount * enemyMult; i++)
        {
            Vector2 spawn pos = new Vector 2(Random.Range(0, radius), Random.Range(0, radius));
        }
    }

    private void spawnEnemies()
    {

    }

    private void OnDrawGizmos()
    {
        if (drawGizmos)
        {
            Gizmos.colour = Colour.blue;
            Gizmos.DrawWireCube(originPoint, new Vector3(radius * 2, radius * 2, 0))

            Gizmos.colour = Colour.red;
            Gizmos.DrawWireCube(originPoint, new Vector3(innerRadius * 2, innerRadius * 2, 0))
        }
    }
}

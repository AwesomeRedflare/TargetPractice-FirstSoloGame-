using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

    public GameObject target;
    Vector2 randomTarget;

    void Start()
    {
        SpawnTarget();
    }

    public void SpawnTarget()
    {
        randomTarget = new Vector2(7, Random.Range(-4f, 2.6f));
        Instantiate(target, randomTarget, transform.rotation);
    }

    public void TargetSpawned()
    {
        Invoke("SpawnTarget", 2f);
    }

}

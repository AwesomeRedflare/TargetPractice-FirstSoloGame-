using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowSpawner : MonoBehaviour
{
    public Rigidbody2D arrow;

    public static float diffuculty;

    private void Start()
    {
        diffuculty = 0;
        SpawnArrow();
    }

    void SpawnArrow()
    {
        diffuculty += 0.5f;
      Rigidbody2D clone;
      clone = Instantiate(arrow, transform.position, transform.rotation);

    }

    public void WaitForSpawn()
    { 
        Invoke("SpawnArrow", 2f);
    }
}

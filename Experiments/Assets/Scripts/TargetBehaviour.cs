using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    public TargetSpawner target_Spawner;


    private void OnCollisionEnter2D(Collision2D win)
    {
        if (win.gameObject.CompareTag("Arrow"))
        {
            
            Destroy(gameObject, 2f);
            target_Spawner.TargetSpawned();
        }
    }
}

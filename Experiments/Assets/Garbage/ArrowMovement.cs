using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float arrowSpeed;
    public GameObject ArrowSpawn;
    

    void Update()
    {
        transform.Translate(Vector2.right * arrowSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Target"))
        {
            arrowSpeed = 0f;
            Destroy(gameObject, 2f);

            
            
        }
    }
}

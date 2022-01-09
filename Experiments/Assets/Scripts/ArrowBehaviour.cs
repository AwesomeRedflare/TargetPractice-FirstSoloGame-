using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowBehaviour : MonoBehaviour
{

    public ArrowSpawner arrowSpawner;

    public float speed;
    public float arrowSpeed;

    public GameObject shotEffect;
    public GameObject hitEffect;
    
    private bool isShot;
    private bool isGoingUp = true;


    private void Start()
    {
        isShot = false;
        
       
    }

    void Update()
    {
        if (isShot == false)
        {
            if (isGoingUp == true)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + (speed + ArrowSpawner.diffuculty) * Time.deltaTime);
                if (transform.position.y > 3)
                {
                    isGoingUp = false;
                }
            }

            if (isGoingUp == false)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + (-speed - ArrowSpawner.diffuculty) * Time.deltaTime);
                if (transform.position.y < -4)
                {
                    isGoingUp = true;
                }
            }

            if (Input.GetKeyDown("space"))
            {
                isShot = true;
                Instantiate(shotEffect, transform.position, Quaternion.identity);
               
       
            }
        }

        if (isShot == true)
        {
           transform.Translate(Vector2.right * arrowSpeed * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Target"))
        {
            Instantiate(hitEffect, transform.position, Quaternion.identity);
            Score.scoreAmount += 1;
            arrowSpeed = 0f;
            Destroy(gameObject, 2f);
            arrowSpawner.WaitForSpawn();
        }

        if (target.gameObject.CompareTag("Game Over"))
        {
            Destroy(gameObject);
        }
    }

}

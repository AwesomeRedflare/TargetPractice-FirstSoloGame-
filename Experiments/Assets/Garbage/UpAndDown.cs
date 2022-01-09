using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public float speed;
    private bool isGoingUp = true;

    void Update()
    {
     
            if (isGoingUp == true)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
                if (transform.position.y > 3)
                {
                    isGoingUp = false;
                }
            }

        if (isGoingUp == false)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
            if (transform.position.y < -3)
            {
                isGoingUp = true;
            }
        }
    }
}

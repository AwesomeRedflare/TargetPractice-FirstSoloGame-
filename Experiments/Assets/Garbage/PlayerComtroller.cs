using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComtroller : MonoBehaviour
{
    public Rigidbody2D arrow;
    public bool AmountOfArrows = true;

  

    void Update()
    {
        if (Input.GetKeyDown("space") && AmountOfArrows == true)
        {
            AmountOfArrows = false;
            Rigidbody2D clone;
            clone = Instantiate(arrow, transform.position,transform.rotation);
            
        }
    }


}

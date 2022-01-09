using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsUpAndDown : MonoBehaviour
{
    private Vector2 targetUp;
    private Vector2 targetDown;

    private void Start()
    {
        targetUp = new Vector2(-8f, 3f);
        targetDown = new Vector2(-8f, -3f);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetUp, 0.1f);
        transform.position = Vector2.MoveTowards(transform.position, targetDown, 0.1f);
    }
}

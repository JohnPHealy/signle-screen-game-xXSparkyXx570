using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIPatrol : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> move;

    [SerializeField] private float moveDir = 1f;
    private bool turn;


    // Update is called once per frame
    void Update()
    {
        if (turn)
        {
            moveDir *= -1;
            turn = false;
        }
        move.Invoke(moveDir);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PatrolPoint")
        {
            turn = true;
        }
       
    }
}

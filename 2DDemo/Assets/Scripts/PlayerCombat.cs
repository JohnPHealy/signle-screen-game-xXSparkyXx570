using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Collider2D playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;

    private bool killplayer = false;
    private GameObject player;


    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            Destroy(gameObject);
            killplayer = false;
        }

        if (killplayer)
        {
            Destroy(player);
            killplayer = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           manager.RespawnPlayer();
        }
    }
}


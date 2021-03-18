using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;

    private void Start()
    {
        startPos = player.transform.position;
    }

    public void RespawnPlayer()
    {
        player.transform.position = startPos;
    }
}

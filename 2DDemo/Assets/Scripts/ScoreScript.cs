using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
   public Text MyscoreText;
   private int ScoreNum;

   void Start()
   {
      ScoreNum = 0;
      MyscoreText.text = "Coins: " + ScoreNum;
   }

   private void OnTriggerEnter2D(Collider2D coin)
   {
      if (coin.tag == "MyCoin")
      {
         ScoreNum += 1;
         Destroy(coin.gameObject);
         MyscoreText.text = "Coins: " + ScoreNum;
      }
   }
}

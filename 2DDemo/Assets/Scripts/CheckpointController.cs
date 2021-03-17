
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
   public bool checkpointReached;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         checkpointReached = true;
      }
   }
}

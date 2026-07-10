using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnLevel : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      ScoreControl.totalScore = 0;
      SceneManager.LoadScene(4);
   }

   // Update is called once per frame
   //void Update()
   //{

   //}
}

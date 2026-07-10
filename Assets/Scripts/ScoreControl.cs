using UnityEngine;

public class ScoreControl : MonoBehaviour
{
   [SerializeField] GameObject scoreBox;
   public static int totalScore = 0;


   // Start is called once before the first execution of Update after the MonoBehaviour is created
   //void Start()
   //{

   //}

   // Update is called once per frame
   void Update()
   {
      scoreBox.GetComponent<TMPro.TMP_Text>().text = "Score: " + totalScore;
   }
}

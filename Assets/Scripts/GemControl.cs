using UnityEngine;

public class GemControl : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   //void Start()
   //{

   //}

   [SerializeField] float rotateSpeed = 0.2f;
   [SerializeField] AudioSource gemCollect;
   [SerializeField] int gemScore = 100;

   // Update is called once per frame
   void Update()
   {
      transform.Rotate(0, rotateSpeed, 0, Space.World);
   }

   void OnTriggerEnter(Collider other)
   {
      ScoreControl.totalScore += gemScore;
      gemCollect.Play();
      Destroy(gameObject);
      
   }
}

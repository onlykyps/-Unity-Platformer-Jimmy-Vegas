using System.Collections;
using UnityEngine;

public class TimeLevel : MonoBehaviour
{
   [SerializeField] GameObject timeBox;
   [SerializeField] int timeLeft = 30;
   [SerializeField] bool takingSecond = false;

   [SerializeField] AudioSource timeUpSound;
   [SerializeField] GameObject levelBGM;
   [SerializeField] GameObject fadeOut;
   [SerializeField] GameObject timeUp;

   [SerializeField] GameObject playerControl;


   // Start is called once before the first execution of Update after the MonoBehaviour is created
   //void Start()
   //{

   //}

   // Update is called once per frame
   void Update()
   {
      timeBox.GetComponent<TMPro.TMP_Text>().text = "Time left: " + timeLeft;
      if (takingSecond == false)
         StartCoroutine(RemoveSecond());

      if (timeLeft == 0)
      {
         takingSecond = true;
         levelBGM.SetActive(false);
         timeUpSound.Play();
         fadeOut.SetActive(true);
         timeUp.SetActive(false);

         playerControl.GetComponent<PlayerController>().enabled = false;
         playerControl.GetComponent<Animator>().Play("Idle");
      }
   }

   IEnumerator RemoveSecond()
   {
      takingSecond = true;
      yield return new WaitForSeconds(1);
      timeLeft -= 1;
      takingSecond = false;
   }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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
   [SerializeField] bool isRespawning = false;


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

      if (timeLeft == 0 && isRespawning == false)
      {
         isRespawning = true;

         takingSecond = true;
         levelBGM.SetActive(false);
         timeUpSound.Play();
         fadeOut.SetActive(true);
         timeUp.SetActive(true);

         playerControl.GetComponent<PlayerController>().enabled = false;
         playerControl.GetComponent<Animator>().Play("Idle");

         StartCoroutine(Respawn());
      }
   }

   IEnumerator RemoveSecond()
   {
      takingSecond = true;
      yield return new WaitForSeconds(1);
      timeLeft -= 1;
      takingSecond = false;
   }

   IEnumerator Respawn()
   {
      yield return new WaitForSeconds(2f);
      SceneManager.LoadScene(3);
   }
}

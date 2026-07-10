using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOff : MonoBehaviour
{
   [SerializeField] AudioSource fallSound;
   [SerializeField] GameObject levelBGM;
   [SerializeField] GameObject fadeOut;

   void OnTriggerEnter(Collider other)
   {
      levelBGM.SetActive(false);
      fallSound.Play();
      fadeOut.SetActive(true);
      
      StartCoroutine(Respawn());

   }

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   //void Start()
   //{

   //}

   //// Update is called once per frame
   //void Update()
   //{

   //}

   IEnumerator Respawn()
   {
      yield return new WaitForSeconds(2f);
      SceneManager.LoadScene(3);
   }
}

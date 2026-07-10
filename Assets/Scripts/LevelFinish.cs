using UnityEngine;

public class LevelFinish : MonoBehaviour
{
   [SerializeField] GameObject playerControl;
   [SerializeField] AudioSource levelJingle;
   [SerializeField] GameObject levelBGM;
   [SerializeField] GameObject fadeOut;

   void OnTriggerEnter(Collider other)
   {
      playerControl.GetComponent<PlayerController>().enabled = false;
      playerControl.GetComponent<Animator>().Play("Idle");
      levelBGM.SetActive(false);
      levelJingle.Play();
      fadeOut.SetActive(true);
   }

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   //void Start()
   //{

   //}

   //// Update is called once per frame
   //void Update()
   //{

   //}
}

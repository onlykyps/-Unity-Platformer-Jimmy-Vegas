using Unity.VisualScripting;
using UnityEngine;

public class LevelMaintain : MonoBehaviour
{
   public static int levelNumber;
   [SerializeField] int internalNumber;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      internalNumber = levelNumber;
   }

   // Update is called once per frame
   void Update()
   {

   }
}

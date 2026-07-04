using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] CharacterController characterController;
   [SerializeField] Vector3 playerVelocity;
   [SerializeField] bool groundedPlayer;
   [SerializeField] float playerSpeed;
   [SerializeField] float gravityValue;
   [SerializeField] GameObject activeCharacter;
   [SerializeField] float moveHorizontal;
   [SerializeField] float moveVertical;
   [SerializeField] float speed = 4;
   [SerializeField] float rotateSpeed = 4;
   [SerializeField] float jumpHight = 1.2f;
   [SerializeField] bool isJumping;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {

   }
}

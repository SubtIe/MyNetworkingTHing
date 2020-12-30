using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : NetworkBehaviour
{
 void HandleMovement()
 {
     if(isLocalPlayer)
     {
         float moveHorizontal = Input.GetAxis("Horizontal");
         float moveVertical = Input.GetAxis("Vertical");
         Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertical * .01f,0f);
         transform.position = transform.position + movement;
     }
 }

 void Update()
 {
     HandleMovement();
 }


}

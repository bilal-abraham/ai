using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour{

    public float Speed = 15f;

    // Update is called once per frame
    void Update(){
        PlayerMovement();
        
    }

    void PlayerMovement(){
         float ver = Input.GetAxis("Vertical");
         float hor = Input.GetAxis("Horizontal");
         Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
         transform.Translate(playerMovement, Space.Self);
    }
}

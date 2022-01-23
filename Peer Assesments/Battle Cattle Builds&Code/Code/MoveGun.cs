using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    float countDown = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update(){
    // rotate right
  if (Input.GetKey(KeyCode.I)){
  	transform.Rotate(0,5f,0);
  }
  // rotate left
  if (Input.GetKey(KeyCode.U)){
  	transform.Rotate(0,-5f,0);
  }
  /*
  if(Input.GetKey(KeyCode.Space)){
      transform.position += transform.forward * -1;
      //transform.position += transform.forward;
  
    
  }
  */
    }
    
}



using System.Collections.Generic;


using UnityEngine;
using System.Collections;
 
public class Press_Space_to_Fire : MonoBehaviour
{
    //Drag in the Bullet Emitter 
    public GameObject Bullet_Emitter;
 
    //Drag in the Bullet Prefab 
    public GameObject Bullet;
 
    //Enter the Speed of the Bullet 
    public float Bullet_Forward_Force;
 
        // Use this for initialization
        void Start ()
    {
       
        }
       
        
        void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            //The Bullet instantiation happens here. Making new bullet evrytime (need to delete them later)
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position,Bullet_Emitter.transform.rotation) as GameObject;
 
            //this is to correct the orientation of my bullets
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 180);
 
            //Access the Rigidbody component
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
 
            //Adding the force the buller
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
 
            //this is so i can destroy the bulets after 7 seconds so my unity project doesn't keep on storing new objects.
            Destroy(Temporary_Bullet_Handler, 7.0f);
        }
    }
}
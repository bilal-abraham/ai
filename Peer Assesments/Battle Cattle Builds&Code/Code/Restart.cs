using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//import SceneManagement, allowing us to using the SceneManager object
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the 'R' key is pressed...
        if (Input.GetKeyDown(KeyCode.R))
        {
            /* Call the scene manager method called 'LoadScene' and
               load "Sample Scene" (The only scene in the game).
               This could be used to change levels, but by calling
               the same scene, this function effectively reloads the game. */
            SceneManager.LoadScene("SampleScene");
        }
    }
}

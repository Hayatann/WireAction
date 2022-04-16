using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    void Start()
    {
        FadeManager.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            FadeManager.FadeOut(1);
        }

        if(Input.GetKeyDown(KeyCode.H)){
            FadeManager.FadeOut(2);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            Application.Quit();
        }
    }

}

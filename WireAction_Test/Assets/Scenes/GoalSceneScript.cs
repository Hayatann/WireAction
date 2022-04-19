using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalSceneScript : MonoBehaviour
{
    public GameObject Time_object = null;
    public GameObject score_object = null;
    // Start is called before the first frame update
    void Start()
    {
        FadeManager.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        Text time_text = Time_object.GetComponent<Text>();
        time_text.text = "ClearTime:" + TimeScript.getSeconds() + "s";
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Score:" + ScoreScript.getScore();
        if(Input.GetKeyDown(KeyCode.E)){
            FadeManager.FadeOut(0);
        }
    }
}

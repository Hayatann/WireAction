using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    private float jumpForce = 300.0f;


    public int jumpCount = 0;

    float walkspeed = 6.0f;


    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        Transform Playertransform = this.transform;
        Vector3 worldPos = Playertransform.position;
        float x = worldPos.x;    // ワールド座標を基準にした、x座標が入っている変数
        float y = worldPos.y;    // ワールド座標を基準にした、y座標が入っている変数
        float z = worldPos.z; 

        if(y < -25){
            SceneManager.LoadScene("GameOver");
            GameManager.instance.score = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 2)
        {
            GetComponent<AudioSource>().Play();
            rbody2D.constraints = RigidbodyConstraints2D.FreezePositionY;
            this.rbody2D.AddForce(transform.up * jumpForce);
            rbody2D.constraints = RigidbodyConstraints2D.None;
            jumpCount++;
        }

        
        
        this.transform.position += new Vector3(walkspeed * Time.deltaTime, 0 ,0);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor")) //床に触れたら二段ジャンプできるようになるよ
        {
            jumpCount = 0;
        }
        if (other.gameObject.tag == "dead"){
            SceneManager.LoadScene("GameOver"); //針に触れたらGameOverシーン呼び出すよ
            GameManager.instance.score = 0;
    }

        if (other.gameObject.tag == "Goal"){
            SceneManager.LoadScene("GoalScene"); //旗に触れたらゴールシーン呼び出すよ
            GameManager.instance.score = 0;
        }
    }
    
}

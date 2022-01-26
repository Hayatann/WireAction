using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    private float jumpForce = 250.0f;

    private int jumpCount = 0;

    float walkspeed = 6.0f;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 2)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }
        
        this.transform.position += new Vector3(walkspeed * Time.deltaTime, 0 ,0);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            jumpCount = 0;
        }
        if (other.gameObject.tag == "dead"){
            SceneManager.LoadScene("GameOver");
        }
    }
    
}

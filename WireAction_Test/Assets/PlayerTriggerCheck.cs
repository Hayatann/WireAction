using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerCheck : MonoBehaviour
{
    [HideInInspector] public bool isOn = false;
    private string playerTag = "Player";
    public AudioClip coinSE;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == playerTag){
            isOn = true;
            AudioSource.PlayClipAtPoint( coinSE, transform.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == playerTag){
            isOn = false;
        }
    }
}

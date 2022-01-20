using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player1");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = this.player.transform.position;
        transform.position = new Vector3(playerpos.x + 5 , playerpos.y , transform.position.z);
    }
}

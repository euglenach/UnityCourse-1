using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 0.5f; //プレイヤーのスピードを制御する変数を作る
	
	//フレーム毎に呼び出される関数
	void Update () {

        if (Input.GetKey("right") && transform.position.x < 20) {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey("left") && transform.position.x > -20) {
            transform.position -= transform.right * speed;
        }
    }
}

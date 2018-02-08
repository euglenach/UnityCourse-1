using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    bool can_start = true;
    float speed = 10f;

    void Update() {

        if (Input.anyKeyDown && can_start) {//何かボタンを押すとスタートする(1回目だけ) 
            can_start = false;
            GetComponent<Rigidbody>().AddForce((Vector2.up + Vector2.right) * speed, ForceMode.VelocityChange);//物理演算を使って力を加える関数。
        }                                                                                                //.upと.rigthを組み合わせると右斜め上にとぶ

    }

}
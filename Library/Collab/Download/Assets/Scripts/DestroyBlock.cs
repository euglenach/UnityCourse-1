using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour {

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ball") Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//SceneManager.LoadSceneメソッドを使うための記述

public class GameControl : MonoBehaviour {

    public GameObject gamecleartext;
    public GameObject gameovertext;
    public GameObject ball;

    void Update() {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        Debug.Log(count);

        if (count == 0) {
            gamecleartext.SetActive(true);
            Invoke("ToTitleScene", 3);//3秒後にToTitleScene関数を実行する関数
        }

        if(ball.transform.position.y < -15) {
            gameovertext.SetActive(true);
            Invoke("ToTitleScene", 3.5f);
        }

    }

    void ToTitleScene() {
        SceneManager.LoadScene("title");//シーン移遷をするための関数
    }
}

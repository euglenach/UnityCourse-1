using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//SceneManager.LoadSceneメソッドを使うための記述

public class LoadScene : MonoBehaviour {

    public void ToMainScene() {
        SceneManager.LoadScene("main");//Scene移遷をするための関数
    }

}

using UnityEngine;

public class GameSize //: MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad() {
        Screen.SetResolution(900, 600, false, 60);

    }

}
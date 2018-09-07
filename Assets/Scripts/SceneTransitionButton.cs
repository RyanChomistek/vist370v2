using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionButton : MonoBehaviour {
    public string NextScene;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(NextScene);
    }
}

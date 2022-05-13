using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonBehavior : MonoBehaviour {
    public void OnScene1() {
        SceneManager.LoadScene("3D");
    }
    public void OnScene2() {
        SceneManager.LoadScene("Basically2D");
    }
    public void OnScene3() {
        SceneManager.LoadScene("Collision test");
    }
    public void OnScene4() {
        SceneManager.LoadScene("Solar System");
    }
    public void OnQuit() {
        Application.Quit();
    }
    
}

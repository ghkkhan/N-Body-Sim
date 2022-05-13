using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ButtonBehavior : MonoBehaviour {
    public float goalSpeed = 1.0f;
    public TMP_Text speedText;

    public void OnPauseButtonPress() {
        goalSpeed = 0.0f;
    }
    public void OnPlayButtonPress() {
        goalSpeed = 1.0f;
    }
    public void OnTwoXSpeed() {
        if (goalSpeed > 0.0f) {
            goalSpeed *= 2.0f;
        } else {
            goalSpeed = 2.0f;
        }
    }
    public void onHalfSpeed() {
        if (goalSpeed > 0.0f) {
            goalSpeed *= 0.5f;
        } else {
            goalSpeed = 0.5f;
        }
    }
    public void onMenu() {
        SceneManager.LoadScene("Menu");
    }

    // Gradually change timeScale when a button is pressed, for a smoother experience
    void TimeStep(float target) {
        if (Mathf.Abs(target - Time.timeScale) < 0.05f) Time.timeScale = target;
        else if (Time.timeScale == 0.0f) Time.timeScale = 0.1f;
        else if (Time.timeScale > target && Time.timeScale < target + 1.0f) Time.timeScale -= 0.04f;
        else if (Time.timeScale < target && Time.timeScale > target + 1.0f) Time.timeScale += 0.04f;
        else if (Time.timeScale > target) Time.timeScale *= 0.9f;
        else if (Time.timeScale < target) Time.timeScale *= 1.1f;
    }

    // Apply gradual change, and show current speed in GUI.
    void Update() {
        if (Time.timeScale != goalSpeed) TimeStep(goalSpeed);
        if (speedText != null) {
            speedText.text = "Current speed: " + Time.timeScale;
        }
    }
}

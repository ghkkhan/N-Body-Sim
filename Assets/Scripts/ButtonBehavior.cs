using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonBehavior : MonoBehaviour {
    private const float PLAY = 1f;
    private const float PAUSED = 0f;
    private const float SPEDUP = 2f;
    private const float SLOWDOWN = 0.5f;

    public float goalSpeed = PLAY;

    public void OnPauseButtonPress() {
        goalSpeed = PAUSED;
    }
    public void OnPlayButtonPress() {
        goalSpeed = PLAY;
    }
    public void OnTwoXSpeed() {
        goalSpeed = SPEDUP;
    }
    public void onHalfSpeed() {
        goalSpeed = SLOWDOWN;
    }

    // Gradually change timeScale when a button is pressed, for a smoother experience
    void TimeStep(float target) {
        if (Time.timeScale > target) Time.timeScale -= 0.04f;        
        else Time.timeScale += 0.04f;
        if (Mathf.Abs(target - Time.timeScale) < 0.05f) Time.timeScale = target;
    }
    void Update() {
        if (Time.timeScale != goalSpeed) TimeStep(goalSpeed);
    }
}

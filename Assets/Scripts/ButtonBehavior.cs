using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonBehavior : MonoBehaviour {
    private const float PLAY = 1f;
    private const float PAUSED = 0f;
    private const float SPEDUP = 2f;
    private const float SLOWDOWN = 0.5f;

    private float a = PLAY;

    public void OnPauseButtonPress() {
        a = PAUSED;
    }
    public void OnPlayButtonPress() {
        a = PLAY;
    }
    public void OnTwoXSpeed() {
        a = SPEDUP;
    }
    public void onHalfSpeed() {
        a = SLOWDOWN;
    }

    void TimeStep(float target) {
        if (Time.timeScale > target) Time.timeScale -= 0.04f;        
        else Time.timeScale += 0.04f;
        if (Mathf.Abs(target - Time.timeScale) < 0.05f) Time.timeScale = target;
    }
    void Update() {
        if (Time.timeScale != a) TimeStep(a);
    }
}

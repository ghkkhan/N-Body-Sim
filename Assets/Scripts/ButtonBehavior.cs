using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {
    public void OnPauseButtonPress() {
        Time.timeScale = 0;
    }
    public void OnPlayButtonPress() {
        Time.timeScale = 1;
    }
    public void OnTwoXSpeed() {
        Time.timeScale = 2;
    }
    public void onHalfSpeed() {
        Time.timeScale = 0.5f;
    }
}

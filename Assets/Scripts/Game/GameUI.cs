using System;
using TMPro;
using UnityEngine;

namespace Game {
    public class GameUI : MonoBehaviour {

        public TMP_Text text;
        public Animator animator;

        public void OnEnable() {
            text.text = "Goal Reached!";
            animator.Play("fade");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
using System;
using UnityEngine;

namespace Utilities {
    public class MouseCameraController : MonoBehaviour {

        [Header("Parameters")] 
        public Camera mainCamera;
        public float sensitivity = 100f;
        public Transform playerBody;

        public float xRotation = 0f;
        public float yRotation = 0f;

        private void Awake() {
            mainCamera = Camera.main;
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update() {
            var mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            var mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            
            yRotation -= mouseY;
            yRotation = Mathf.Clamp(yRotation, -90f, 90f);
            
            mainCamera.transform.localEulerAngles = new Vector3(yRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
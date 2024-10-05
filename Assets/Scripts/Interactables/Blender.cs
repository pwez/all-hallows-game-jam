using System;
using Players;
using Players.Controllers;
using UnityEngine;

namespace Interactables
{

    // The following is an example of how we can implement a general interactable mechanic

    public class Blender : MonoBehaviour {
        
        public void TurnOn() {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Blender On");
        }
        
        public void TurnOff() {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("Blender Off");
        }

    }

}
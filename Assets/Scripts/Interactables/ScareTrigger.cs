using Players;
using Players.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interactables
{

    public class ScareTrigger : MonoBehaviour
    {
        //public UnityEvent OnPressActionButtonEvent;
        

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log("Entered into " + name);
            if (!IsPlayer(other, out var player)) return;

            this.transform.parent.GetComponent<Blender>().TurnOn();
            player.SwitchTo<ScaredState>();
        }

        private void OnTriggerExit(Collider other)
        {
            //Debug.Log("Entered into " + name);
            if (!IsPlayer(other, out var player)) return;

            this.transform.parent.GetComponent<Blender>().TurnOff();
        }


        private bool IsPlayer(Collider other, out IPlayer player)
        {
            return other.TryGetComponent<IPlayer>(out player);
        }
    }

}
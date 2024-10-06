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
        [SerializeField] GameObject _blender;
        [SerializeField] GameObject _player;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsPlayer(other, out var player)) return;
            StartCoroutine(JumpScared(player));
            // Fade to black here?

        }

        private void OnTriggerExit(Collider other)
        {
            if (!IsPlayer(other, out var player)) return;

            _player.transform.eulerAngles = new Vector3(0, 0, 0);
            this.transform.parent.GetComponent<Blender>().TurnOff();
        }


        private bool IsPlayer(Collider other, out IPlayer player)
        {
            return other.TryGetComponent<IPlayer>(out player);
        }

        IEnumerator JumpScared(IPlayer player)
        {
            player.SwitchTo<ScaredState>();
            _player.transform.LookAt(_blender.transform);
            this.transform.parent.GetComponent<Blender>().TurnOn();

            yield return new WaitForSeconds(2);    
        }
    }

}
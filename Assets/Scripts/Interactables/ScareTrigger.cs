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
            StartCoroutine(JumpScared(other));
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

        IEnumerator JumpScared(Collider other)
        {
            this.transform.parent.GetComponent<Blender>().TurnOn();
            _player.transform.LookAt(_blender.transform);
            yield return new WaitForSeconds(2);
            IsPlayer(other, out var player);
            player.SwitchTo<ScaredState>();
        }
    }

}
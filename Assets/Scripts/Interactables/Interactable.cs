using System;
using Players;
using Players.Controllers;
using UnityEngine;

namespace Interactables {

    // The following is an example of how we can implement a general interactable mechanic
    
    public interface IInteractable {
        void OnInteract();
    }
    
    public class Door : IInteractable {
        public void OnInteract() {
            throw new NotImplementedException();
        }
    }
    
    public class InteractionTrigger : MonoBehaviour {

        private IInteractable _interactable;
        
        private void OnTriggerEnter(Collider other) {
            if (!IsPlayer(other, out var player)) return;
            if (!IsPressingInteractButton(player)) return;
            
            _interactable.OnInteract();
        }

        private bool IsPressingInteractButton(IPlayer player) {
            return player.Controller.Get<IActionInput>().IsPressed;
        }

        private bool IsPlayer(Collider other, out IPlayer player) {
            return other.TryGetComponent<IPlayer>(out player);
        }
        
    }
    
}
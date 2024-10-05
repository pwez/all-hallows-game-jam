using Players;
using Players.Controllers;
using UnityEngine;

namespace Interactables
{
    public class InteractionTrigger : MonoBehaviour {

        private IInteractable _interactable;
        
        private void OnTriggerEnter(Collider other) {
            if (!IsPlayer(other, out var player)) return;
            if (!IsPressingInteractButton(player)) return;
            
            _interactable.OnInteract();
        }

        private bool IsPressingInteractButton(IPlayer player) {
            return player.Controller.ActionInput.IsPressed;
        }

        private bool IsPlayer(Collider other, out IPlayer player) {
            return other.TryGetComponent<IPlayer>(out player);
        }
        
    }
    
}
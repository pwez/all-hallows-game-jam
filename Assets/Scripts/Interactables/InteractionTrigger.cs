using Players;
using Players.Controllers;
using UnityEngine;
using UnityEngine.Events;

namespace Interactables
{
    
    
    public class InteractionTrigger : MonoBehaviour {
        public UnityEvent OnPressActionButtonEvent;
        
        private void OnTriggerStay(Collider other) {
            if (!IsPlayer(other, out var player)) return;
            if (!IsPressingInteractButton(player)) return;
            
            Destroy(gameObject.transform.parent.gameObject);
        }

        private bool IsPressingInteractButton(IPlayer player) {
            return player.Controller.ActionInput.IsHeld;
        }

        private bool IsPlayer(Collider other, out IPlayer player) {
            return other.TryGetComponent<IPlayer>(out player);
        }
        
    }
    
    
}
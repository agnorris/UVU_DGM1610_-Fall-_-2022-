using UnityEngine;
using UnityEngine.Events;

namespace Unit_6_Challenge
{
    public class PutAway : MonoBehaviour
    {
        public GameObject powerup;
    
        void Start()
        {
            Debug.Log("Inventory Contents");
        }

        private void OnTriggerEvent(Collision other)
        {
            Debug.Log("Power-up"); 
            Destroy(other.gameObject);
        }

    }
}

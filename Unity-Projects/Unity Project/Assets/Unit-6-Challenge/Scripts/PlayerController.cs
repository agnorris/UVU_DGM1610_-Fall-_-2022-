using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unit_6_Challenge.Scripts
{
    public class PlayerController : MonoBehaviour
    
    {
        public float horizontalInput;
        public float speed;
        public float verticalInput;
        public GameObject powerup;
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * (horizontalInput * speed));
            transform.Translate(Vector3.up * (verticalInput * speed));

        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Powerup");
            Destroy(powerup);
        }
    }
}

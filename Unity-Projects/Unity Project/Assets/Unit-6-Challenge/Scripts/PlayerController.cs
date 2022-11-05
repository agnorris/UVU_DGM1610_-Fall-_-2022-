using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unit_6_Challenge.Scripts
{
    public class PlayerController : MonoBehaviour
    
    {
        public float horizontalInput;
        public float speed;
        public float verticalInput;
        public float xRange;
        public float zRange;
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * (horizontalInput * speed));
            transform.Translate(Vector3.forward * (verticalInput * speed));
            
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
            }

            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name.StartsWith("Health"))
            {
              Debug.Log("Health Powerup");  
              Destroy(other.GameObject());
            }
            if (other.gameObject.name.StartsWith("Attack"))
            {
                Debug.Log("Attack Powerup");  
                Destroy(other.GameObject());
            }
            if (other.gameObject.name.StartsWith("Defense"))
            {
                Debug.Log("Defense Powerup");  
                Destroy(other.GameObject());
            }
        }
    }
}

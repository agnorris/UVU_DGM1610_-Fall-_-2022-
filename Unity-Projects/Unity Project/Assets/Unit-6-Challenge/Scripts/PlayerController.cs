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
        public GameObject hpowerup;
        public GameObject apowerup;
        public GameObject dpowerup;
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
            if (hpowerup)
            { 
                //destroying this powerup
                Debug.Log( "Health Powerup");
                Destroy(other.GameObject());
            }

            if (apowerup)
            {
                Debug.Log("Attack Powerup");
                Destroy(other.GameObject());
            }

            if (dpowerup)
            {
                //giving this log
                Debug.Log("Defense Powerup");  
                Destroy(other.GameObject());
            }
        }
    }
}

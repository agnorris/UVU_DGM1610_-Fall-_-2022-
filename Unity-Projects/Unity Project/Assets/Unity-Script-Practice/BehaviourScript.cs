using UnityEngine;

namespace Unity_Script_Practice
{
    public class BehaviourScript : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
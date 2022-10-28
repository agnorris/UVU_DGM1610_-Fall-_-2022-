using UnityEngine;

namespace Unity_Script_Practice
{
    public class Conventionsandsyntax : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(transform.position.x);

            if (transform.position.y <= 7f)
            {
                Debug.Log("Hi");
            }
        }
    }
}

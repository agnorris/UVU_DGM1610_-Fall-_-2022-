using UnityEngine;

namespace Unit_5_Challenge
{
    public class FirstMonoEventsBehavior : MonoBehaviour
    {
        private void OnBecameVisible()
        {
            enabled = true;
        }

        private void OnBecameInvisible()
        {
            enabled = false;
        }
    }
}

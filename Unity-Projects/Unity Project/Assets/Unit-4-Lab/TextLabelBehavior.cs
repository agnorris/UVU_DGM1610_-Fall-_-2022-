using UnityEngine;
using UnityEngine.UI;

namespace Unit_4_Lab
{
    [RequireComponent(typeof(Text))]

    public class TextLabelBehavior : MonoBehaviour
    {
        public Text label;
        public FloatData  dataObj;

        private void Start()
        {
            label = GetComponent<Text>();
            label.text = dataObj.value.ToString();
        }
    }
}

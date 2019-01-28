using TMPro;
using UnityEngine;

namespace PixelCurio.GGJ2019
{
    public class Output : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _output;

        public void AppendText(string text) => _output.text += text;
        public void SetText(string text) => _output.text = text;
    }
}

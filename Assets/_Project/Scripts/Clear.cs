using UnityEngine;
using Zenject;

namespace PixelCurio.GGJ2019
{
    public class Clear : MonoBehaviour
    {
        [Inject] private readonly Output _output;

        private const float REGISTER_TIME = 4f;

        private float _activeTime;
        private bool _isActive;

        public void Start()
        {
            _activeTime = Time.time;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            _isActive = true;
            _activeTime = Time.time;
        }

        public void OnTriggerExit2D(Collider2D collision)
        {
            _isActive = false;
        }

        public void Update()
        {
            if(_isActive && Time.time - _activeTime > REGISTER_TIME)
            {
                Debug.Log($"Registered the letter: {gameObject.name}");
                _output.SetText("");
                _activeTime = Time.time;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

namespace PixelCurio.GGJ2019
{
    public class QuestionView : MonoBehaviour
    {
        [Inject] private readonly JsonObjects _jsonObjects;
        [SerializeField] private TextMeshProUGUI _questionText;

        public void Start()
        {
            _questionText.text = _jsonObjects.GetRandomQuestion();
        }
    }
}

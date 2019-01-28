using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Zenject;

namespace PixelCurio.GGJ2019
{
    public class JsonObjects : IInitializable
    {
        public Questions data;

        public void Initialize()
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, "questions.json");
            if (File.Exists(filePath))
            {
                string dataAsJson = File.ReadAllText(filePath);
                data = JsonUtility.FromJson<Questions>(dataAsJson);
                Debug.Log($"Successfully loaded: {data.questions[0].Question}");
            }
        }

        public string GetRandomQuestion()
        {
            return data.questions[UnityEngine.Random.Range(0, data.questions.Count)].Question + "?";
        }
    }

    [Serializable]
    public class Questions
    {
        public List<QuestionEntry> questions;
    }

    [Serializable]
    public class QuestionEntry
    {
        public string Rank;
        public string Question;
        public string GlobalMonthlySearch;
        public string GlobalCPC;
        public string RelatedKeywords;
    }
}

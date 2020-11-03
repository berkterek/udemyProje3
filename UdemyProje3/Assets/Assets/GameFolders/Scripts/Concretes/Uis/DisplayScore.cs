using System.Collections;
using System.Collections.Generic;
using TMPro;
using UdemyProje3.Managers;
using UnityEngine;

namespace UdemyProje3.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
            _scoreText.text = GameManager.Instance.Score.ToString();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnScoreChanged += HandleScoreChanged;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleScoreChanged;
        }

        private void HandleScoreChanged(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}


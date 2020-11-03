using System.Collections;
using System.Collections.Generic;
using TMPro;
using UdemyProje3.Abstracts.Combats;
using UdemyProje3.Controllers;
using UdemyProje3.Managers;
using UnityEngine;

namespace UdemyProje3.Uis
{
    public class QuestionPanel : MonoBehaviour
    {
        [SerializeField] ResultPanel resultPanel;

        TextMeshProUGUI _messageText;
        int _lifeCount;
        IHealth _playerHealth;

        private void Awake()
        {
            _messageText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        }

        private void OnDisable()
        {
            _lifeCount = 0;
            _playerHealth = null;
        }

        public void SetLifeCountAndReferences(int lifeCount, IHealth playerHealth)
        {
            _lifeCount = lifeCount;
            _messageText.text = $"Do you want buy {_lifeCount} life?";
            _playerHealth = playerHealth;
        }

        public void YesClick()
        {
            resultPanel.gameObject.SetActive(true);

            if (_lifeCount <= GameManager.Instance.Score)
            {
                resultPanel.SetResultMessage($"You have bouht {_lifeCount} life have a good day...");
                GameManager.Instance.DecreaseScore(_lifeCount);
                _playerHealth.Heal(_lifeCount);
            }
            else
            {
                resultPanel.SetResultMessage("You do not have enouth diamond please try again later");
            }

            this.gameObject.SetActive(false);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Combats;
using UdemyProje3.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace UdemyProje3.Uis
{
    public class DisplayHealth : MonoBehaviour
    {
        Image _healthImage;
        IHealth _health;

        private void Awake()
        {
            _healthImage = GetComponent<Image>();
        }

        private void OnEnable()
        {
            _health = FindObjectOfType<PlayerController>().GetComponent<IHealth>();
            _health.OnHealthChanged += HandleHealthChanged;
        }

        private void OnDisable()
        {
            _health.OnHealthChanged -= HandleHealthChanged;
            _healthImage.fillAmount = 1f;
        }

        private void HandleHealthChanged(int currentHealth, int maxHealth)
        {
            _healthImage.fillAmount = (float)currentHealth / (float)maxHealth;
        }
    }
}


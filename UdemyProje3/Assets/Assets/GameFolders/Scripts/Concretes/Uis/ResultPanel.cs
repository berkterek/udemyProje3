using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UdemyProje3.Uis
{
    public class ResultPanel : MonoBehaviour
    {
        TextMeshProUGUI _resultMessage;

        private void Awake()
        {
            _resultMessage = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        }

        public void SetResultMessage(string result)
        {
            _resultMessage.text = result;
        }
    }
}


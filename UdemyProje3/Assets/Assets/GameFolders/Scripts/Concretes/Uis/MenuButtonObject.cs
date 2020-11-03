using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Enums;
using UdemyProje3.Managers;
using UnityEngine;

namespace UdemyProje3.Uis
{
    /// <summary>
    /// Menu panel icindeki ButtonObjects ait bir component'tir bu component'in amaci icinde Menu start ve quit methodlari icin yazilmistir
    /// </summary>
    public class MenuButtonObject : MonoBehaviour
    {
        public void StartGame()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }

        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Enums;
using UdemyProje3.Managers;
using UnityEngine;

namespace UdemyProje3.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }

        public void NoButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Menu);
        }
    }
}


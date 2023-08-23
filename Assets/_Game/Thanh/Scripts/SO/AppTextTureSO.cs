using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ThanhDev
{
    [CreateAssetMenu(fileName = "AppTextTure", menuName = "Thanh_Script/AppTextTureSO")]

    [System.Serializable]
    public class App
    {
        public Sprite sprite;
        public AppType appType;
    }

    public class AppTextTureSO : ScriptableObject
    {
        public Sprite[] AppSprites;

        public int currentAppsIndex = 0;

        public App[] apps;

        public App GetApp()
        {
            if (currentAppsIndex >= 12)
            {
                currentAppsIndex = 0;
            }
            return apps[currentAppsIndex++];
        }
    }
}
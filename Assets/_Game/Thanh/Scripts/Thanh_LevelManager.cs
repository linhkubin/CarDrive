using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace ThanhDev
{   
    public class Thanh_LevelManager : MonoBehaviour
    {
        #region Game1

        [Header("Game1")]
        [SerializeField] GameObject spawnPrefab;

        public int numRow;
        public int numCol;

        public float rowSpacing;
        public float colSpacing;


        public void OnClick()
        {
            for (int i = 1; i <= numRow; i++)
            {
                for (int j = 1; j <= numCol; j++)
                {
                    Vector3 spawnPosition = new Vector3(transform.position.x + (1f * j - (numRow + 1) / 2f) * colSpacing, transform.position.y + (1f * i - (numCol + 1) / 2f) * rowSpacing, transform.position.z - 0.6f);
                    GameObject nGO = Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
                }
            }
        }

        #endregion
    }

}


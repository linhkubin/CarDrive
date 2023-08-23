using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DungGame2_UIManager : Singleton<DungGame2_UIManager>
{
    [SerializeField] private List<ChestBtn> listChestBtn;
    [SerializeField] private TextMeshProUGUI maxMoneyTxt;
    [SerializeField] private Sprite normalChestImg;
    [SerializeField] private Sprite premiumChestImg;
    private List<string> listMoneyTxt = new List<string>() { "50", "100", "200", "500" };
    private void Start()
    {
        int rnd = UnityEngine.Random.Range(0, listChestBtn.Count);
        for (int i =0; i < listChestBtn.Count; i ++)
        {
            if (i == rnd) listChestBtn[i].AssignBtn(premiumChestImg, "500", true);
            else listChestBtn[i].AssignBtn(normalChestImg, listMoneyTxt[UnityEngine.Random.Range(0,listMoneyTxt.Count-1)], false);
        }
    }
}

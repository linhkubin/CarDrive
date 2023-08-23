using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestBtn : MonoBehaviour
{
    private Button button;
    [SerializeField]private GameObject chest;
    [SerializeField] private Image chestImg;
    [SerializeField] private GameObject throneImg;
    [SerializeField] private TextMeshProUGUI moneyTxt;
    [SerializeField] private GameObject adsImg;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if (!DungGame2_GameManager.Instance.CheckCount()) return;
        if(this.chest.activeInHierarchy)DungGame2_GameManager.Instance.MinusCount();
        this.chest.SetActive(false);
    }
    public void AssignBtn(Sprite sprite, string money, bool checkVip)
    {
        this.chestImg.sprite = sprite;
        this.moneyTxt.text = money;
        if (checkVip) this.AssignThrone();
    }
    private void AssignThrone()
    {
        this.throneImg.SetActive(true);
        this.adsImg.SetActive(true);
    }
}

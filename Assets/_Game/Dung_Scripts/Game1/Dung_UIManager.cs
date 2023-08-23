using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dung_UIManager : Singleton<Dung_UIManager>
{
    [SerializeField] private List<ImageSOJ> listImages;
    [SerializeField] private List<ImageBtn> listBtn;
    [SerializeField] private Image imageTheme;
    [SerializeField] private TextMeshProUGUI textTheme;
    private List<Sprite> oldSprite;
    [SerializeField]private List<int> listRnd;
    int correctIndexType;
    private void Start()
    {
        oldSprite = new List<Sprite>();
        Dung_GameManager.Instance.CurrentImageType = (TypeOfImage)UnityEngine.Random.Range(0, Enum.GetValues(typeof(TypeOfImage)).Length);
        this.AssignTextTheme();
        for (int i = 0; i < listImages.Count; i++)
        {
            if (Dung_GameManager.Instance.CompareType(listImages[i].type)) correctIndexType = i;
        }
        Sprite sprite = listImages[correctIndexType].spriteImage[UnityEngine.Random.Range(0, listImages[correctIndexType].spriteImage.Count)];
        imageTheme.sprite = sprite;
        oldSprite.Add(sprite);
        listRnd = new List<int>();
        while(listRnd.Count < 3)
        {
            int rnd = UnityEngine.Random.Range(0, 6);
            if (!listRnd.Contains(rnd)) listRnd.Add(rnd);
        }
        for ( int i = 0; i < listBtn.Count; i ++)
        {
            listBtn[i].SetIndex(i);
            if (listRnd.Contains(i))  AssignCorrectImage(listBtn[i]);
            else AssignUncorrectImage(listBtn[i]);
        }
    }
    private void AssignCorrectImage(ImageBtn btn)
    {
        int count = listImages[correctIndexType].spriteImage.Count;
        Sprite sprite = listImages[correctIndexType].spriteImage[UnityEngine.Random.Range(0, count)];
        if (oldSprite.Contains(sprite)) AssignCorrectImage(btn);
        else
        {
            oldSprite.Add(sprite);
            btn.ChangeImage(sprite);
        }
    }
    private void AssignUncorrectImage(ImageBtn btn)
    {
        int check = UnityEngine.Random.Range(0, listImages.Count);
        if (check == correctIndexType) AssignUncorrectImage(btn);
        else
        {
            int count = listImages[check].spriteImage.Count;
            Sprite sprite = listImages[check].spriteImage[UnityEngine.Random.Range(0, count)];
            if (oldSprite.Contains(sprite)) AssignUncorrectImage(btn);
            else
            {
                oldSprite.Add(sprite);
                btn.ChangeImage(sprite);
            }
        }
    }
    public void CheckWin()
    {
        if (Dung_GameManager.Instance.CheckWin(listRnd)) Debug.Log("Win");
        else Debug.Log("lose");
    }
    private void AssignTextTheme()
    {
        if (Dung_GameManager.Instance.CompareType(TypeOfImage.Car)) textTheme.text = "Cars";
        else if (Dung_GameManager.Instance.CompareType(TypeOfImage.Plane)) textTheme.text = "Planes";
        else if (Dung_GameManager.Instance.CompareType(TypeOfImage.Traffic)) textTheme.text = "Traffic";

    }
}

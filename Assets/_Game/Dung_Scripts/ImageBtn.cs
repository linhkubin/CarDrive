using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ImageBtn : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private GameObject imageTick;
    private int index;
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if (Dung_GameManager.Instance.countdown == 0 && !imageTick.activeInHierarchy) return;
        imageTick.SetActive(!imageTick.activeInHierarchy);
        if (imageTick.activeInHierarchy) Dung_GameManager.Instance.countdown--;
        else Dung_GameManager.Instance.countdown++;
        Dung_GameManager.Instance.CheckType(index, imageTick.activeInHierarchy);
    }
    public void ChangeImage(Sprite sprite) 
    {
        image.sprite= sprite;
    }
    public void SetIndex(int i)
    {
        this.index = i;
    }
}

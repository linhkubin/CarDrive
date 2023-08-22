using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DATA", menuName = "ScriptableObjects/Image", order = 1)]
public class ImageSOJ : ScriptableObject
{
    public TypeOfImage type;
    public List<Sprite> spriteImage;
}
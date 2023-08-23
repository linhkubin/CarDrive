using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Dung_GameManager : Singleton<Dung_GameManager>
{
    private TypeOfImage currentTypeImage;
    public int countCorrect = 0;
    public int countdown = 3;
    [SerializeField]private List<int> chosenInt = new List<int>();
    public bool CompareType(TypeOfImage type)
    {
        if (this.currentTypeImage == type) return true;
        return false;
    }
    public TypeOfImage CurrentImageType { set { currentTypeImage = value; }  }
    public void CheckType(int index, bool boolean)
    {
        if (boolean) this.chosenInt.Add(index);
        else this.chosenInt.Remove(index);

    }
    public bool CheckWin(List<int> list)
    {
        if (list.Count != chosenInt.Count) return false;
        for (int i = 0; i < chosenInt.Count; i++)
        {
            if (!list.Contains(chosenInt[i])) return false;
        }
        return true;
    }
   
}
public enum TypeOfImage
{
    Car,
    Plane,
    Traffic
}

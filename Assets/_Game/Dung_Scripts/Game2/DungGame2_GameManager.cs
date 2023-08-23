using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungGame2_GameManager : Singleton<DungGame2_GameManager>
{
    private int countdown = 3;
    public bool CheckCount()
    {
        if (countdown == 0) return false; return true;
    }
    public void MinusCount()
    {
        countdown--;
    }
    public void BonusAds()
    {
        countdown += 3;
    }
}

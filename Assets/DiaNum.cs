using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaNum : MonoBehaviour
{
    [SerializeField] private TMP_Text text = null;
    private int diaNum = 0;
    public void GetDia()
    {
        text.text = string.Format("{0:0}", ++diaNum);
    }

    public void SubDia()
    {
        if (diaNum > 0)
        {
            --diaNum;
            text.text = string.Format("{0:0}", diaNum);
        }
    }
}

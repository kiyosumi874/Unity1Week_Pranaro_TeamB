using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Gauge : MonoBehaviour
{
    [SerializeField] private Image fullImage = null;
    
    /// <summary>
    /// O2Gauge��ω�������
    /// </summary>
    /// <param name="num">�ǂꂾ���ω������邩�̐��l(0.0f�`1.0f)</param>
    public void ChangeO2Gauge(float num)
    {
        fullImage.fillAmount += num;
    }
}
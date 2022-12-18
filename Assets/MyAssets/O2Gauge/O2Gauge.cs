using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Gauge : MonoBehaviour
{
    [SerializeField] private Image fullImage = null;
    
    /// <summary>
    /// O2Gauge‚ğ•Ï‰»‚³‚¹‚é
    /// </summary>
    /// <param name="num">‚Ç‚ê‚¾‚¯•Ï‰»‚³‚¹‚é‚©‚Ì”’l(0.0f`1.0f)</param>
    public void ChangeO2Gauge(float num)
    {
        fullImage.fillAmount += num;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Gauge : MonoBehaviour
{
    [SerializeField] private Image fullImage = null;
    [SerializeField] private float easyDecreaseO2 = 0.01f;
    [SerializeField] private float normalDecreaseO2 = 0.025f;
    [SerializeField] private float hardDecreaseO2 = 0.05f;

    private float decreaseO2 = 0.01f;
    void Start()
    {
        switch (SceneLoader.GetNowScene())
        {
            case SceneLoader.Scene.Easy:
                decreaseO2 = easyDecreaseO2;
                break;
            case SceneLoader.Scene.Normal:
                decreaseO2 = normalDecreaseO2;
                break;
            case SceneLoader.Scene.Hard:
                decreaseO2 = hardDecreaseO2;
                break;
            case SceneLoader.Scene.None:
                decreaseO2 = easyDecreaseO2;
                break;
            default:
                decreaseO2 = easyDecreaseO2;
                break;
        }
    }

    void Update()
    {
        fullImage.fillAmount -= decreaseO2 * Time.deltaTime;
    }

    /// <summary>
    /// O2Gauge‚ğ•Ï‰»‚³‚¹‚é
    /// </summary>
    /// <param name="num">‚Ç‚ê‚¾‚¯•Ï‰»‚³‚¹‚é‚©‚Ì”’l(0.0f`1.0f)</param>
    public void ChangeO2Gauge(float num)
    {
        fullImage.fillAmount += num;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Gauge : MonoBehaviour
{
    [SerializeField] private Image fullImage = null;
    [SerializeField] private SceneChanger sceneChanger = null;
    [SerializeField] private StateManager stateManager = null;
    [SerializeField] private float easyDecreaseO2 = 0.01f;
    [SerializeField] private float normalDecreaseO2 = 0.025f;
    [SerializeField] private float hardDecreaseO2 = 0.05f;
    private State state = null;

    private float decreaseO2 = 0.01f;
    void Start()
    {
        state = this.gameObject.AddComponent<State>();
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
        if (state.CompareState(State.StateType.Play))
        {
            fullImage.fillAmount -= decreaseO2 * Time.deltaTime;
            if (fullImage.fillAmount <= 0.0f)
            {
                stateManager.SetStateAll(State.StateType.Stop);
                this.enabled = false;
                sceneChanger.ChangeScene();
            }
        }

            
    }

    /// <summary>
    /// O2Gaugeを変化させる
    /// </summary>
    /// <param name="num">どれだけ変化させるかの数値(0.0f〜1.0f)</param>
    public void ChangeO2Gauge(float num)
    {
        fullImage.fillAmount += num;
    }
}

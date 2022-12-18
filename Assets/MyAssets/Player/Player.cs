using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float easyLerpPower = 1.5f;
    [SerializeField] private float normalLerpPower = 1.0f;
    [SerializeField] private float hardLerpPower = 0.5f;
    [SerializeField] private SceneChanger sceneChanger = null;
    [SerializeField] private StateManager stateManager = null;
    [SerializeField] private O2Gauge o2Gauge = null;

    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    private State state = null;
    private float lerpPower = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        state = this.gameObject.AddComponent<State>();
        switch (SceneLoader.GetNowScene())
        {
            case SceneLoader.Scene.Easy:
                lerpPower = easyLerpPower;
                break;
            case SceneLoader.Scene.Normal:
                lerpPower = normalLerpPower;
                break;
            case SceneLoader.Scene.Hard:
                lerpPower = hardLerpPower;
                break;
            case SceneLoader.Scene.None:
                lerpPower = easyLerpPower;
                break;
            default:
                lerpPower = easyLerpPower;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CompareState(State.StateType.Play))
        {
            if (this.transform.position.x > 2.5f)
            {
                normalLerpPower = 0.0f;
                this.transform.position = new Vector3(2.5f, this.transform.position.y, 0.0f);
                return;
            }

            if (this.transform.position.x < -2.5f)
            {
                normalLerpPower = 0.0f;
                this.transform.position = new Vector3(-2.5f, this.transform.position.y, 0.0f);
                return;
            }

            // Vector3でマウス位置座標を取得する
            position = Input.mousePosition;
            // Z軸修正
            position.z = 10f;
            // マウス位置座標をスクリーン座標からワールド座標に変換する
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            var posX = Vector3.Lerp(this.transform.position, screenToWorldPointPosition, Time.deltaTime * lerpPower).x;
            // ワールド座標に変換されたマウス座標を代入
            this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            collision.enabled = false;
            stateManager.SetStateAll(State.StateType.Stop);
            sceneChanger.ChangeScene();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var decreasePal = collision.gameObject.GetComponent<O2Decreaser>().GetDecreasePal();
        o2Gauge.ChangeO2Gauge(-decreasePal);
    }
}

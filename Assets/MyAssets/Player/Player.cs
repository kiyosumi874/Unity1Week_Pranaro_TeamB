using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float lerpPower = 5.0f;
    [SerializeField] private SceneChanger sceneChanger = null;
    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            sceneChanger.ChangeScene();
        }
    }
}

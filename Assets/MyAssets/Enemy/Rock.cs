using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    GameObject Player;
    GameObject MoveObj;
    MoveObj script;
    private float delta;
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
        this.MoveObj = GameObject.Find("MoveObj");
        script = MoveObj.GetComponent<MoveObj>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionStay2D()
    {
        //岩に引っかかったとき、Moveobjが固まる
        if (this.Player.transform.position.y < -3.0f)
        {
            Debug.Log("ひっかかった！");
            //MoveObjのｙ座標の移動量を０にする
            this.script.nowPower = 0.0f;
        }
    }
    
    void OnCollisionExit2D()
    {
        //Playerのｙ座標を-3.0fに戻す
        this.delta = this.Player.transform.position.y + 3.0f;
        Player.transform.Translate(0, - this.delta, 0);
    }
}

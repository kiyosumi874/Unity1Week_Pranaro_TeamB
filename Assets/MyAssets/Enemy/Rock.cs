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
        //��Ɉ������������Ƃ��AMoveobj���ł܂�
        if (this.Player.transform.position.y < -3.0f)
        {
            Debug.Log("�Ђ����������I");
            //MoveObj�̂����W�̈ړ��ʂ��O�ɂ���
            this.script.nowPower = 0.0f;
        }
    }
    
    void OnCollisionExit2D()
    {
        //Player�̂����W��-3.0f�ɖ߂�
        this.delta = this.Player.transform.position.y + 3.0f;
        Player.transform.Translate(0, - this.delta, 0);
    }
}

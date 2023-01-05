using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ChaseFish : MonoBehaviour
{
    //[SerializeField] private float chaseTime;
    [SerializeField] private float speed;
    //[SerializeField] private float chaseDistance;
    public GameObject player;
    public GameObject chaseFish;
    private Vector3 nowDistance;
    private bool isInvate;
    float direction;

    // Start is called before the first frame update
    void Start()
    {
        chaseFish = transform.Find("ChaseFish").gameObject;
        //direction = -1;
        isInvate = false;
    }

    // Update is called once per frame
    void Update()
    {
        //縄張りに入ったら追ってくる
        if (isInvate)
        {
            nowDistance = player.transform.position - chaseFish.transform.position;
            //速度の一定化
            nowDistance = Vector3.Normalize(nowDistance);
            //魚だけの位置を変更させる
            chaseFish.transform.Translate(nowDistance * speed * Time.deltaTime);
        }
        //定位置に戻る(きびすを返す)
        //横往復をする
        /*
        else
        {
            if (chaseFish.transform.position.x < -3.5f)
                direction = 1;
            if (chaseFish.transform.position.x > 3.5f)
                direction = -1;
            chaseFish.transform.Translate(speed * Time.deltaTime * direction, 0.0f, 0.0f);
        }
        */
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInvate = true;
        }
    }
        void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInvate = false;
        }

    }
}
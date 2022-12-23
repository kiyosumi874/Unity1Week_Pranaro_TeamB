using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseFish : MonoBehaviour
{
    [SerializeField] private float chaseTime;
    [SerializeField] private float speed;
    [SerializeField] private float chaseDistance;
    public GameObject player;
    private Vector3 nowDistance;
    private bool isInvate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isInvate)
        {
            nowDistance = player.transform.position - transform.position;
            if (nowDistance.y < chaseDistance)
            {
                //近づくと追ってくる敵
                nowDistance = Vector3.Normalize(nowDistance);
                //親の位置を変更させる
                //parent.transform.Translate(nowDistance * speed * Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other)
        {
            isInvate = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other)
        {
            isInvate = false;
        }

    }
}

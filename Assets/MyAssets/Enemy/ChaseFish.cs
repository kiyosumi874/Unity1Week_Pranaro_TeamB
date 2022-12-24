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
        //�꒣��ɓ�������ǂ��Ă���
        if (isInvate)
        {
            nowDistance = player.transform.position - chaseFish.transform.position;
            //���x�̈�艻
            nowDistance = Vector3.Normalize(nowDistance);
            //�������̈ʒu��ύX������
            chaseFish.transform.Translate(nowDistance * speed * Time.deltaTime);
        }
        //��ʒu�ɖ߂�(���т���Ԃ�)
        //������������
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
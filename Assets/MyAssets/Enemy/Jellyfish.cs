using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private float stealthTime;
    [SerializeField] private float attackTime;
    public GameObject player;
    public GameObject jellyfish;
    private bool isInvate;
    private float delta;

    // Start is called before the first frame update
    void Start()
    {
        isInvate = false;
        delta = 0.0f;
        //jellyfish.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //���ꂽ��������肷��
        if(delta > attackTime)
        {
            isInvate = false;
        }
        if(delta > stealthTime + attackTime)
        {
            isInvate = true;
            delta = 0.0f;
        }

        //���X�Ɍ����悤�ɂ��遨�Ȃ��ĂȂ�
        if (isInvate)
        {
            jellyfish.GetComponent<SpriteRenderer>().color += new Color(255, 255, 255, 25);
            //�v���C���[����������A���̏ꏊ�܂ŏu�Ԉړ�
        }
        else
        {
            jellyfish.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInvate = true;
            delta = 0.0f;
        }
    }
}

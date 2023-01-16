using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovingMagma : MonoBehaviour
{
    [SerializeField] private float normalSpeed;
    [SerializeField] private float highSpeed;
    [SerializeField] private float waitTime;
    [SerializeField] private float farDistance;
    public GameObject player;
    private float nowDistance;
    private float delta = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //player = transform.Find("Player").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        nowDistance = player.transform.position.y - transform.position.y;
        if (this.delta > this.waitTime)
        {
            if(nowDistance > farDistance)
            {
                transform.Translate(0.0f, highSpeed * Time.deltaTime, 0.0f);
            }
            else
            {
                transform.Translate(0.0f, normalSpeed * Time.deltaTime, 0.0f);
            }

        }
    }
}

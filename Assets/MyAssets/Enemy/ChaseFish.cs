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


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        nowDistance = player.transform.position - transform.position;
        if(nowDistance.y < chaseDistance)
        {
            //‹ß‚Ã‚­‚Æ’Ç‚Á‚Ä‚­‚é“G
            //transform.Translate(nowDistance/1000 * speed);
            transform.Translate(nowDistance.x / Mathf.Abs(nowDistance) * speed, nowDistance.y / Mathf.Abs(nowDistance)* speed, 0.0f);
        }
    }
}

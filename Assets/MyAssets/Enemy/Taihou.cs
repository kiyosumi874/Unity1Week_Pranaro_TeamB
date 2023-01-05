using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taihou : MonoBehaviour
{
    [SerializeField] private float span;
    float delta = 0;
    float scale;
    float startPoint;
    public GameObject CannonBall;
    //public GameObject BackGroundManager;
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        delta = 0.0f;
        scale = transform.localScale.x;
        if(scale > 0)
        {
            startPoint = 1;
        }
        else
        {
            startPoint = -1;
        }
        go = Instantiate(CannonBall, transform) as GameObject;
        go.transform.position = new Vector3(transform.position.x- 1.5f * startPoint, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(delta > span){
            go = Instantiate(CannonBall, transform) as GameObject;
            go.transform.position = new Vector3(transform.position.x- 1.5f * startPoint, transform.position.y, 0);
            delta = 0.0f;
        }
    }
}

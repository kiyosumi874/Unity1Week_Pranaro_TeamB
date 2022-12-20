using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taihou : MonoBehaviour
{
    [SerializeField] private float span;
    float delta = 0;
    public GameObject CannonBall;
    public GameObject MoveObj;
    
    // Start is called before the first frame update
    void Start()
    {
        span = 0.0f;
        delta = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(delta > span){
            GameObject go = Instantiate(CannonBall, MoveObj.transform) as GameObject;
            go.transform.position = new Vector3(transform.position.x - 1.0f, transform.position.y, 0);
            delta = 0.0f;
        }
    }
}

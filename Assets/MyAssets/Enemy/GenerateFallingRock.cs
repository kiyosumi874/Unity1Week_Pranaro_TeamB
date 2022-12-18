using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFallingRock : MonoBehaviour
{
    [SerializeField] private float _span;
    float delta = 0;
    public GameObject FallingRock;
    FallingRock script;
    float speed;
    float span;
    float GereratePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        this.FallingRock = GameObject.Find("FallingRock");
        this.script = FallingRock.GetComponent<FallingRock>();
        this.speed = this.script._Speed;
        this.span = this.script._span;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this._span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FallingRock) as GameObject;
            go.transform.position = new Vector3(0, 25, 0);
            //this.GereratePoint = speed * span *  10;
            //go.transform.position = transform.Translate(0.0f, this.GereratePoint, 0.0f);
        }
    }
}
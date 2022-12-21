using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFallingRock : MonoBehaviour
{
    [SerializeField] private float _span;
    float delta = 0;
    public GameObject FallingRock;
    //public GameObject BackGroundManager;
    GameObject go;
    FallingRock script;
    float GereratePoint;
    float span;
    
    // Start is called before the first frame update
    void Start()
    {
        this.script = FallingRock.GetComponent<FallingRock>();
        this.span = this.script._span;
        go = Instantiate(FallingRock, transform) as GameObject;
        go.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this._span)
        {
            this.delta = 0;
            go = Instantiate(FallingRock, transform) as GameObject;
            go.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
}
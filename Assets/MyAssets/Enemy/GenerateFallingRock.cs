using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFallingRock : MonoBehaviour
{
    [SerializeField] private float _span;
    float delta = 0;
    public GameObject FallingRock;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this._span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FallingRock) as GameObject;
            go.transform.position = new Vector3(0, 25, 0);
        }
    }
}

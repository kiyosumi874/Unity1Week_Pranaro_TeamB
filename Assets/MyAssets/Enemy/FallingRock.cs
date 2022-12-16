using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    [SerializeField] private float _Speed;
    float span = 1.0f;
    float delta = 0;

    //[SerializeField] private float _Speed;
    //int i;
    //private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, _Speed * Time.deltaTime, 0.0f);
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            Destroy(gameObject);
            this.delta = 0;
            GameObject go = Instantiate(gameObject) as GameObject;
            go.transform.position = new Vector3(0, 25, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    [SerializeField] public float _Speed;
    [SerializeField] public float _span;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, -_Speed * Time.deltaTime * 5.0f, 0.0f);
        this.delta += Time.deltaTime;
        if(this.delta > this._span)
        {
            Destroy(gameObject);
            this.delta = 0;
        }
    }
}

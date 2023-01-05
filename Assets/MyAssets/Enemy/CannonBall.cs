using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField] public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * transform.localScale.x / Mathf.Abs(transform.localScale.x) / 100, 0.0f, 0.0f);
        if(transform.position.x > 3.5f | transform.position.x < -3.5f){
            Destroy(gameObject);
        }
    }
}

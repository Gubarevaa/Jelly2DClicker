using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyCloneMini : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 10), Random.Range(5, 10)), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

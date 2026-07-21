using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Private Rigidbody2d rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity =new Vector2(-1f,2f);
    }
}

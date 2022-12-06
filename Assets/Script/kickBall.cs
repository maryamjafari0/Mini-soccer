using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickBall : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject top;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb=top.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)&&baAi.onay){
            Vector3 direction =-(transform.position-top.transform.position).normalized;
            rb.AddForce(-direction*speed*Time.deltaTime,ForceMode2D.Impulse);
            baAi.onay=false;
            baAi.flyToEs=false;
        }
    }
}

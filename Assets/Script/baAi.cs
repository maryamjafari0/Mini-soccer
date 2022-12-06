using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baAi : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject es;
    Vector2 esDirection;
    float timeStamp;
    public static bool flyToEs;
    [Header("Win")]
    [HideInInspector]
    public bool lookingRight = true;

    private Rigidbody2D rb2d;

    public GameObject top;

    public static bool onay;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(flyToEs){
            esDirection=-(transform.position-es.transform.position).normalized;
            rb.velocity= new Vector2 (esDirection.x , esDirection.y)* 5f*(Time.time/timeStamp);

        }
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("PlayerMagnet")){
            timeStamp=Time.time;
            es=GameObject.Find("Player");
            flyToEs=true;
            onay=true;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        flyToEs=false;
    }
}

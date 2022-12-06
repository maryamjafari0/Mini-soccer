using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

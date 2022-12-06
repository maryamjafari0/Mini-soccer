using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse2 : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition),moveSpeed);
        Vector3 difference=Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        difference.Normalize();
       // float rotation_z=Mathf.Atan2(difference.y , difference.x) * Mathf.Rad20eg;
       // transform.rotation=Quaternion.Euler(0f,0f,rotation_z);
    }
}

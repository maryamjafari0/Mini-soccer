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

    public int score=0;
    // Start is called before the first frame update
    void Start()
    {
         int rand = Random.Range(0,2);
        if (rand ==0){
            this.GetComponent<Rigidbody2D> ().velocity=new Vector2 (-5f,0f);

        }
        else if (rand ==1){
            this.GetComponent <Rigidbody2D> ().velocity = new Vector2 (5f, 0f);
            
        }
    }

    private void Update(){
        //var pos=transform.position;
        //if(pos.x(GameObject.FindGameObjectWithTag("Ball"))==(pos.x(GameObject.FindGameObjectWithTag("goalpe"))=12.8f)){ 
           // score++;
       // }

    }
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed;
    public Animator anim;

   // public float rayLength;

   // private bool moveLeft;

   // public Transform contactChecker;
    public Transform waypt1;
    public Transform waypt2;
    Vector3 targetpos;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = waypt1.position;
        anim.SetTrigger("left");
        // moveLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(transform.position,waypt1.position)<=0.5f)
        {
            anim.SetTrigger("right");
            targetpos = waypt2.position;
        }
        else if(Vector2.Distance(transform.position, waypt2.position) <= 0.5f)
        {
            anim.SetTrigger("left");
            
            targetpos = waypt1.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetpos, moveSpeed * Time.deltaTime);
        

    }
   

    //private void FixedUpdate()
    //{
    //    RaycastHit2D contactcheck = Physics2D.Raycast(contactChecker.position, Vector2.left, rayLength);

    //    if(contactcheck == true)
    //    {
    //        if(moveLeft == true)
    //        {
    //            transform.eulerAngles = new Vector2(0, -180);
    //            moveLeft = false;
    //        }
    //        else
    //        {
    //            transform.eulerAngles = new Vector2(0, 0);
    //            moveLeft = true;
    //        }
    //    }
    //}

}

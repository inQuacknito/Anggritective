﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathTurun : Enemy
{
    public Transform target;
    public float chaseRadius;
    //public float attackRadius;
    //private Transform homePosition;

    public float pathLength;
    private Vector3 homePosition, post1;
    private bool goHome;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        currentState = EnemyState.walk;
        homePosition = transform.position;
        post1 = homePosition - new Vector3(0, pathLength, 0);
        goHome = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
        whereToMove();
        botMove();
    }
/*
    void CheckDistance(){
        if(Vector3.Distance(target.position, transform.position)<=chaseRadius &&
        Vector3.Distance(target.position, transform.position)>attackRadius){
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed*Time.deltaTime);
        }
    }
*/
    void CheckDistance(){
        if(Vector3.Distance(target.position, transform.position)<=chaseRadius){
            SceneManager.LoadScene("Ketangkep");
        }
    }
    void whereToMove(){
        if(Vector3.Distance(homePosition, transform.position)>=pathLength 
        && Vector3.Distance(post1, transform.position)<pathLength
        && !goHome){
            goHome = true;
        } else if(Vector3.Distance(post1, transform.position)>=pathLength 
        && Vector3.Distance(homePosition, transform.position)<pathLength
        && goHome){
            goHome = false;
        }
    }
    void botMove(){
        if(goHome){
            transform.position = transform.position + new Vector3(0, moveSpeed*Time.deltaTime, 0);
            SetAnimFloat(Vector2.up);
        } else {
            transform.position = transform.position - new Vector3(0, moveSpeed*Time.deltaTime, 0);
            SetAnimFloat(Vector2.down);
        }
        ChangeState(EnemyState.walk);
        anim.SetBool("moving", true);
    }
    private void ChangeState(EnemyState newState){
        if(currentState != newState){
            currentState = newState;
        }
    }
    private void SetAnimFloat(Vector2 setVector){
        anim.SetFloat("moveX", setVector.x);
        anim.SetFloat("moveY", setVector.y);
    }
}
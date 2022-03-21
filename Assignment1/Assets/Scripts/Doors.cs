using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator animator;
   
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isOpen_Obj_1", true);
    }
    private void OnTriggerClose(Collider other)
    {
        animator.SetBool("isOpen_Obj_1", false);
    }
}

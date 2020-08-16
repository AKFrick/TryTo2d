using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animator;

    public string KeyRun;

    bool running;

    void Update()
    {
        if (Input.GetKeyDown(KeyRun))
            running = true;
        if (Input.GetKeyUp(KeyRun))
            running = false;

        animator.SetBool("isRun", running);
    }
}


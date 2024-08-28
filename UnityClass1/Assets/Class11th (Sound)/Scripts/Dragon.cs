using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] Animator animator;
    private int count = 0;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        if(count >= 10)
        {
            animator.SetTrigger("Die");
            return;
        }
        count++;
        SoundManager.instance.Listen(audioClip);
    }

    public void Release()
    {
        Destroy(gameObject);
    }

}

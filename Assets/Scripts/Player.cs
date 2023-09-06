using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public RuntimeAnimatorController[] animCon;

    private Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void OnEnable()
    {
        anim.runtimeAnimatorController = animCon[GameManager.Instance.PlayerId];
    }
}

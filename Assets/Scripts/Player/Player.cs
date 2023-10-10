using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string name = null;
    public string Name
    {
        get
        {
            return name == null ? null : name;
        }
        set
        {
            name = value;
        }
    }

    private int id = 0;
    public int Id
    {
        get
        {
            return id == -1 ? -1 : id;
        }
        set
        {
            id = value;
        }
    }

    public RuntimeAnimatorController[] animCon;

    private Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void OnEnable()
    {
        anim.runtimeAnimatorController = animCon[GameManager.Instance.Player.Id];
    }
}

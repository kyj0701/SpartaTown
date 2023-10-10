using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MemberManager : MonoBehaviour
{
    private static MemberManager instance = null;
    public static MemberManager Instance
    {
        get
        {
            return instance == null ? null : instance;
        }
    }

    public List<Character> characters;

    void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        characters = new List<Character>();
    }

    void Start()
    {
        // init characters (player is not in characters in this game)
        AddMember(new Character("¿°¿¹Âù Æ©ÅÍ´Ô", 1));
    }

    public void AddMember(Character character)
    {
        characters.Add(character);
    }

    public void RemoveMemeber(Character character)
    {
        characters.Remove(character);
    }

    public void RemoveMemeber(int index)
    {
        characters.RemoveAt(index);
    }
}

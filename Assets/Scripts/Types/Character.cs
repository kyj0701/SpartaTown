using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
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

    public Character(string _name, int _id)
    {
        name = _name;
        id = _id;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            return instance == null ? null : instance;
        }
    }

    [SerializeField] private Player player;
    public Player Player
    {
        get
        {
            return player == null ? null : player;
        }
    }

    private string playerName = null;
    public string PlayerName
    {
        get
        {
            return playerName == null ? null : playerName;
        }
        set
        {
            playerName = value;
        }
    }
    private int playerId = 0;
    public int PlayerId
    {
        get
        {
            return playerId == -1 ? -1 : playerId;
        }
        set
        {
            playerId = value;
        }
    }

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
    }

    public void GameStart()
    {
        player.gameObject.SetActive(true);
    }

    public void CharacterSet(int id)
    {
        playerId = id;
    }
}

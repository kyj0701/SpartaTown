using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;
    public static UIManager Instance
    {
        get
        {
            return instance == null ? null : instance;
        }
    }

    public TextMeshProUGUI playerName;

    [SerializeField] private TextMeshProUGUI[] memberNameTexts;

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

    public void SetPlayerName()
    {
        playerName.text = GameManager.Instance.Player.Name;
    }

    public void SetMembersText()
    {
        Character[] names = MemberManager.Instance.characters.ToArray();

        memberNameTexts[0].gameObject.SetActive(true);
        memberNameTexts[0].text = GameManager.Instance.Player.Name;

        for (int i = 0; i < names.Length; i++)
        {
            memberNameTexts[i + 1].gameObject.SetActive(true);
            memberNameTexts[i + 1].text = names[i].Name;
        }
    }
}

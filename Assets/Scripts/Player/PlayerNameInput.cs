using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public GameObject nameCanvas;

    public void InputName()
    {
        if (playerNameInput.text.Length >= 2 && playerNameInput.text.Length <= 10)
        {
            GameManager.Instance.Player.Name = playerNameInput.text;
            UIManager.Instance.SetPlayerName();
            DeactiveNameCanvas();
        }
    }

    public void DeactiveNameCanvas()
    {
        nameCanvas.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectImage : MonoBehaviour
{
    public Sprite[] spritePool;

    private Image characterSprite;

    void Awake()
    {
        characterSprite = GetComponent<Image>();
    }

    public void SetSprite()
    {
        characterSprite.sprite = spritePool[GameManager.Instance.PlayerId];
    }
}

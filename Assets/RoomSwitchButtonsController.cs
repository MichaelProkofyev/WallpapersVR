﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSwitchButtonsController : MonoBehaviour {

    [SerializeField]
    private Image buttonTargetGraphics;
    [SerializeField]
    private Button mainButton;
    [SerializeField]
    private Image secondaryButtonTargetGraphics;
    [SerializeField]
    private Button secondaryButton;

    public void SetMainButtonSprite(Sprite mainButtonSprite)
    {
        buttonTargetGraphics.sprite = mainButtonSprite;
    }

    public void SetButtonSprites(Sprite mainButtonSprite, Sprite secondaryButtonSprite)
    {
        buttonTargetGraphics.sprite = mainButtonSprite;
        secondaryButtonTargetGraphics.sprite = secondaryButtonSprite;
    }
}

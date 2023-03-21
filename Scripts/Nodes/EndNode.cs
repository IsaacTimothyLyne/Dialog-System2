﻿using System;
using UnityEngine;

[Serializable]
public class EndNode : DialogNode
{
    public EndNode(Vector2 position, float width, float height, GUIStyle inPointStyle, GUIStyle outPointStyle, Action<ConnectionPoint> onClickInPoint, Action<ConnectionPoint> onClickOutPoint)
        : base(position, width, height, inPointStyle, outPointStyle, onClickInPoint, onClickOutPoint)
    {
        DialogText = "End";
    }
}

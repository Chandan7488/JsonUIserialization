using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIComponentForEditor : ScriptableObject
{
    public List<UIComponent> listOfComponents;

    public UIComponentForEditor()
    {
        listOfComponents = new List<UIComponent>();
    }
}

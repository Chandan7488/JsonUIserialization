using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(UIComponent))]
public class UIComponentPropertyDrawer : PropertyDrawer
{

    SerializedProperty _property;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        _property = property.FindPropertyRelative("Name");
        EditorGUILayout.PropertyField(_property, new GUIContent("Object"));

        _property = property.FindPropertyRelative("Position");
        EditorGUILayout.PropertyField(_property, new GUIContent("Position"));

        _property = property.FindPropertyRelative("Rotation");
        EditorGUILayout.PropertyField(_property, new GUIContent("Rotation"));

        _property = property.FindPropertyRelative("Scale");
        EditorGUILayout.PropertyField(_property, new GUIContent("Scale"));
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

//[Serializable]
//public class AdTag : UIComponent
//{
//    public AdTag(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class Appdetails : UIComponent
//{
//    public Appdetails(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public AppIconHolder AppIconHolder { get; set; }
//    public AppInfo AppInfo { get; set; }
//}

//[Serializable]
//public class AppIconHolder : UIComponent
//{
//    public AppIconHolder(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public RawImageAdIcon RawImage_adIcon { get; set; }
//}

//[Serializable]
//public class AppInfo : UIComponent
//{
//    public AppInfo(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public TextAdHeadline Text_adHeadline { get; set; }
//    public StarRating StarRating { get; set; }
//    public TextStore Text_store { get; set; }
//    public PriceTxt priceTxt { get; set; }
//}

//[Serializable]
//public class BG : UIComponent
//{
//    public BG(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class ButtonCta : UIComponent
//{
//    public ButtonCta(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    [JsonProperty("Text-CallToAction")]
//    public TextCallToAction TextCallToAction { get; set; }
//}

//[Serializable]
//public class Canvas : UIComponent
//{
//    public Canvas(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public BG BG { get; set; }
//    public Placeholder Placeholder { get; set; }
//    public SampleFormat SampleFormat { get; set; }
//}

//[Serializable]
//public class Fill : UIComponent
//{
//    public Fill(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class Holder : UIComponent
//{
//    public Holder(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public AdTag adTag { get; set; }
//    public RawImageAdchoiceIcon RawImage_adchoiceIcon { get; set; }
//    public Padding Padding { get; set; }
//}

//[Serializable]
//public class Outline : UIComponent
//{
//    public Outline(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class Padding : UIComponent
//{
//    public Padding(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public Appdetails Appdetails { get; set; }
//    public TextBody Text_body { get; set; }
//    public ButtonCta Button_Cta { get; set; }
//}

//[Serializable]
//public class Placeholder : UIComponent
//{
//    public Placeholder(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class PriceTxt : UIComponent
//{
//    public PriceTxt(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class RawImageAdchoiceIcon : UIComponent
//{
//    public RawImageAdchoiceIcon(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class RawImageAdIcon : UIComponent
//{
//    public RawImageAdIcon(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class Root : UIComponent
//{
//    public Root(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public Canvas Canvas { get; set; }
//}

//[Serializable]
//public class SampleFormat : UIComponent
//{
//    public SampleFormat(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public Holder Holder { get; set; }
//}

//[Serializable]
//public class StarRating : UIComponent
//{
//    public StarRating(string name, GameObject parent) : base(name, parent)
//    {
//    }

//    public Fill fill { get; set; }
//    public Outline outline { get; set; }
//}

//[Serializable]
//public class TextAdHeadline : UIComponent
//{
//    public TextAdHeadline(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class TextBody : UIComponent
//{
//    public TextBody(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class TextCallToAction : UIComponent
//{
//    public TextCallToAction(string name, GameObject parent) : base(name, parent)
//    {
//    }
//}

//[Serializable]
//public class TextStore : UIComponent
//{
//    public TextStore(string name, GameObject parent) : base(name, parent) { }
//}

[Serializable]
public class AdTag: UIComponentInfo
{
 
}

[Serializable]
public class Appdetails: UIComponentInfo
{
    public AppIconHolder AppIconHolder { get; set; }
    public AppInfo AppInfo { get; set; }
}

[Serializable]
public class AppIconHolder: UIComponentInfo
{
    public RawImageAdIcon RawImage_adIcon { get; set; }
}

[Serializable]
public class AppInfo: UIComponentInfo
{
    public TextAdHeadline Text_adHeadline { get; set; }
    public StarRating StarRating { get; set; }
    public TextStore Text_store { get; set; }
    public PriceTxt priceTxt { get; set; }
}

[Serializable]
public class BG: UIComponentInfo
{
}

[Serializable]
public class ButtonCta: UIComponentInfo
{
    [JsonProperty("Text-CallToAction")]
    public TextCallToAction TextCallToAction { get; set; }
}

[Serializable]
public class Canvas: UIComponentInfo
{
    public BG BG { get; set; }
    public Placeholder Placeholder { get; set; }
    public SampleFormat SampleFormat { get; set; }
}

[Serializable]
public class Fill: UIComponentInfo
{
}

[Serializable]
public class Holder: UIComponentInfo
{
    public AdTag adTag { get; set; }
    public RawImageAdchoiceIcon RawImage_adchoiceIcon { get; set; }
    public Padding Padding { get; set; }
}

[Serializable]
public class Outline: UIComponentInfo
{
  
}


public class Padding: UIComponentInfo
{
    public Appdetails Appdetails { get; set; }
    public TextBody Text_body { get; set; }
    public ButtonCta Button_Cta { get; set; }
}

[Serializable]
public class Placeholder: UIComponentInfo
{
}

[Serializable]
public class PriceTxt: UIComponentInfo
{
}

[Serializable]
public class RawImageAdchoiceIcon: UIComponentInfo
{
}

[Serializable]
public class RawImageAdIcon: UIComponentInfo
{
}

[Serializable]
public class Root
{
    public Canvas Canvas { get; set; }
}

[Serializable]
public class SampleFormat: UIComponentInfo
{
    public Holder Holder { get; set; }
}

[Serializable]
public class StarRating : UIComponentInfo
{
    public Fill fill { get; set; }
    public Outline outline { get; set; }
}

[Serializable]
public class TextAdHeadline: UIComponentInfo
{
}

[Serializable]
public class TextBody: UIComponentInfo
{
}

[Serializable]
public class TextCallToAction: UIComponentInfo
{
}

[Serializable]
public class TextStore: UIComponentInfo
{
}

[Serializable]
public class UIComponentInfo
{
    public Vector3Pos position;
    public Vector3Pos rotation;
    public Vector3Pos scale;

    public UIComponentInfo()
    {
        position = new Vector3Pos();
        rotation = new Vector3Pos();
        scale = new Vector3Pos();
    }
}

[Serializable]
public class Vector3Pos
{
    public float x;
    public float y;
    public float z;
}


[Serializable]
public class UIComponent
{
    protected RectTransform mRect;
    
    private GameObject mGameobject;

    public Vector3 Position, Rotation, Scale;
    public string Name;

    public UIComponentInfo comp_info, parent_comp_info;

    public UIComponent(string name, GameObject parent)
    {
        Name = name;
        mGameobject = new GameObject(name);
        mRect = mGameobject.AddComponent<RectTransform>();

        if (parent == null) //Its a Canvas
        {
            mGameobject.AddComponent<UnityEngine.UI.CanvasScaler>();

            mGameobject.GetComponent<UnityEngine.Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;

            mGameobject.AddComponent<UnityEngine.UI.GraphicRaycaster>();
        }

        if (parent != null)
        {
            mGameobject.transform.parent = parent.transform;
        }
    }

    public void UpdateRect()
    {
        mRect.localPosition = Position;
        mRect.localRotation = Quaternion.Euler(Rotation);
        mRect.localScale = Scale;

        comp_info.position.x = Position.x;
        comp_info.position.y = Position.y;
        comp_info.position.z = Position.z;

        comp_info.rotation.x = Rotation.x;
        comp_info.rotation.y = Rotation.y;
        comp_info.rotation.z = Rotation.z;

        comp_info.scale.x = Scale.x;
        comp_info.scale.y = Scale.y;
        comp_info.scale.z = Scale.z;
    }

    public RectTransform GetRectTransform()
    {
        return mRect;
    }

    public GameObject GetGameObject()
    {
        return mGameobject;
    }
}

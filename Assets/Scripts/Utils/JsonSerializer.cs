using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JsonLoader
{

    public static void LoadJSON(string path)
    {
        string jsonstring = File.ReadAllText(path);
        var root = JsonConvert.DeserializeObject<Root>(jsonstring);
        Debug.Log(root);
    }

    public static Dictionary<UIComponent, string> GenerateGameObjects(string path, ref Root mRoot) 
    {
        string jsonstring = File.ReadAllText(path);
        Dictionary<UIComponent, string> class_dict = new Dictionary<UIComponent, string>();
        DeserializeJsonToDict(jsonstring, null, ref class_dict, null, ref mRoot);
        Debug.Log(class_dict.Count + " Total Objects");
        return class_dict;
    } 

    private static void DeserializeJsonToDict(string jsonstring , GameObject obj, ref Dictionary<UIComponent, string> class_dict, UIComponentInfo ui_info, ref Root mRoot)
    {
        var root = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonstring);

        foreach (KeyValuePair<string, object> k in root)
        {
            UIComponent class_object = new UIComponent(k.Key, obj);
            class_object.comp_info = new UIComponentInfo();
            class_object.parent_comp_info = ui_info;

            CheckClassObject(class_object, ref mRoot);

            GameObject p = class_object.GetGameObject();

            if (k.Value is JObject)
            {
                DeserializeJsonToDict(k.Value.ToString(), p, ref class_dict, class_object.comp_info, ref mRoot);
            }
            class_dict.Add(class_object, k.Key);
        }
    }

    private static void CheckClassObject(UIComponent ui_info, ref Root mRoot)
    {
        switch (ui_info.Name)
        {
            case "Canvas":
                mRoot.Canvas.position = ui_info.comp_info.position;
                mRoot.Canvas.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.scale = ui_info.comp_info.scale;
                break;
            case "BG":
                mRoot.Canvas.BG.position = ui_info.comp_info.position;
                mRoot.Canvas.BG.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.BG.scale = ui_info.comp_info.scale;
                break;
            case "Placeholder":
                mRoot.Canvas.Placeholder.position = ui_info.comp_info.position;
                mRoot.Canvas.Placeholder.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.Placeholder.scale = ui_info.comp_info.scale;
                break;
            case "SampleFormat":
                mRoot.Canvas.SampleFormat.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.scale = ui_info.comp_info.scale;
                break;
            case "Holder":
                mRoot.Canvas.SampleFormat.Holder.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.scale = ui_info.comp_info.scale;
                break;
            case "AdTag":
                mRoot.Canvas.SampleFormat.Holder.adTag.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.adTag.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.adTag.scale = ui_info.comp_info.scale;
                break;
            case "RawImageAdchoiceIcon":
                mRoot.Canvas.SampleFormat.Holder.RawImage_adchoiceIcon.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.RawImage_adchoiceIcon.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.RawImage_adchoiceIcon.scale = ui_info.comp_info.scale;
                break;
            case "Padding":
                mRoot.Canvas.SampleFormat.Holder.Padding.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.scale = ui_info.comp_info.scale;
                break;
            case "Appdetails":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.scale = ui_info.comp_info.scale;
                break;
            case "AppIconHolder":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.scale = ui_info.comp_info.scale;
                break;
            case "RawImageAdIcon":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.RawImage_adIcon.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.RawImage_adIcon.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppIconHolder.RawImage_adIcon.scale = ui_info.comp_info.scale;
                break;
            case "AppInfo":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.scale = ui_info.comp_info.scale;
                break;
            case "TextAdHeadline":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_adHeadline.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_adHeadline.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_adHeadline.scale = ui_info.comp_info.scale;
                break;
            case "StarRating":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.scale = ui_info.comp_info.scale;
                break;
            case "Fill":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.fill.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.fill.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.fill.scale = ui_info.comp_info.scale;
                break;
            case "Outline":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.outline.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.outline.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.StarRating.outline.scale = ui_info.comp_info.scale;
                break;
            case "TextStore":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_store.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_store.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.Text_store.scale = ui_info.comp_info.scale;
                break;
            case "PriceTxt":
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.priceTxt.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.priceTxt.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Appdetails.AppInfo.priceTxt.scale = ui_info.comp_info.scale;
                break;
            case "TextBody":
                mRoot.Canvas.SampleFormat.Holder.Padding.Text_body.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Text_body.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Text_body.scale = ui_info.comp_info.scale;
                break;
            case "ButtonCta":
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.scale = ui_info.comp_info.scale;
                break;
            case "TextCallToAction":
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.TextCallToAction.position = ui_info.comp_info.position;
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.TextCallToAction.rotation = ui_info.comp_info.rotation;
                mRoot.Canvas.SampleFormat.Holder.Padding.Button_Cta.TextCallToAction.scale = ui_info.comp_info.scale;
                break;
        }
    }

    public static void SerializeToJson(Root mRoot)
    {
        var json_string = JsonConvert.SerializeObject(mRoot);
        string path = Path.Combine(Application.streamingAssetsPath, "UI_Json_1.json");
        if (Directory.Exists(Application.streamingAssetsPath))
        {
            Debug.Log(json_string);
            File.WriteAllText(path, json_string);
        }
    }
}

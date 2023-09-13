using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;

public class JsonToGameObject : EditorWindow
{
    private UIComponentForEditor template_data;
    private bool IsInitComplete = false;

    static JsonToGameObject wnd;

    Root mRoot;

    Vector2 scrollPos;

    public Object obj1;
    public UIComponent obj2;

    [MenuItem("MyTool/JsonToGameObject")]
    private static void Init()
    {
        wnd = GetWindow<JsonToGameObject>();
	}

    Root GetRootClass()
    {
        Root rootInstance = new Root
        {
            Canvas = new Canvas
            {
                BG = new BG(),
                Placeholder = new Placeholder(),

                SampleFormat = new SampleFormat
                {
                    Holder = new Holder
                    {
                        adTag = new AdTag(),
                        RawImage_adchoiceIcon = new RawImageAdchoiceIcon(),
                        Padding = new Padding
                        {
                            Appdetails = new Appdetails
                            {
                                AppIconHolder = new AppIconHolder
                                {
                                    RawImage_adIcon = new RawImageAdIcon()
                                },
                                AppInfo = new AppInfo
                                {
                                    Text_adHeadline = new TextAdHeadline(),
                                    StarRating = new StarRating
                                    {
                                        fill = new Fill(),
                                        outline = new Outline()
                                    },
                                    Text_store = new TextStore(),
                                    priceTxt = new PriceTxt()
                                }
                            },
                            Text_body = new TextBody(),
                            Button_Cta = new ButtonCta
                            {
                                TextCallToAction = new TextCallToAction()
                            }
                        }
                    }
                }
            }
        };

        return rootInstance;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Generate"))
        {
            string final_path = Path.Combine(Application.streamingAssetsPath, "UI_Json_1.json");
            string path = string.Empty;

            if (!File.Exists(final_path))
            {
                path = EditorUtility.OpenFilePanel("Template JSON", "", "*");
                File.Copy(path, final_path);
            }

            AssetDatabase.Refresh();

            mRoot = GetRootClass();

            var _data = JsonLoader.GenerateGameObjects(final_path, ref mRoot);

            if (template_data == null)
                template_data = new UIComponentForEditor();

            foreach (KeyValuePair<UIComponent, string> k in _data)
            {
                template_data.listOfComponents.Add(k.Key);
            }

            IsInitComplete = true;
        }

        if (IsInitComplete)
        {

            SerializedObject o = new SerializedObject(template_data);
            SerializedProperty list = o.FindProperty("listOfComponents");


            using (var h = new EditorGUILayout.HorizontalScope())
            {
                using (var scrollView = new EditorGUILayout.ScrollViewScope(scrollPos, GUILayout.Width(wnd.position.width), GUILayout.Height(wnd.position.height - 50)))
                {
                    scrollPos = scrollView.scrollPosition;
                    for (int i = list.arraySize - 1; i >= 0; i--)
                    {
                        EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i), true);
                        template_data.listOfComponents[(list.arraySize - 1) - i].UpdateRect();
                    }
                }
            }
            o.ApplyModifiedProperties();

            if (GUILayout.Button("Save"))
            {
                Debug.Log(template_data.listOfComponents[list.arraySize - 1].Name);
                JsonLoader.SerializeToJson(mRoot);
                AssetDatabase.Refresh();
            }
        }
    }
}

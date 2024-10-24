using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEngine.UI;
using Config;
using Cards;


public class ImageLoader : MonoBehaviour
{
    public Image img;
    public GameObject cardPrefab;

    void Start()
    {
        // LoadImage();
    }
    

    public void LoadImage()
    {
        string[] extensions = { "image files", "png,jpg,jpeg" };
        var path = EditorUtility.OpenFilePanelWithFilters("Selecciona una imagen para la carta CARTA", "", extensions);
        if (!File.Exists(path)) return;
        byte[] image = File.ReadAllBytes(path);
        CardGeneration.setImage(image);        
        imageRender.Change();

        // string savePath = Application.dataPath + "/algo" + ".prefab";
        // string imageSavePath = Application.dataPath + "/image" + ".jpg";

        // PrefabUtility.SaveAsPrefabAssetAndConnect(cardPrefab,savePath, InteractionMode.UserAction);
    }
}

using Config;
using UnityEngine;
using UnityEngine.UI;

public class imageRender : MonoBehaviour
{
    static bool change = false;
    public Image img;
    void Update()
    {
        if (change)
        {
            ImageView();
            change = false;
        }

    }
    public void ImageView()
    {
        Sprite sprite = CardGeneration.GetImage();
        if (sprite != null)
            img.sprite = sprite;
    }
    public static void Change()
    {
        change = true;
    }
}

using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class BaseInput : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI textComponent;
    private string currentTextValue;
    
    private string prop;
    void Start(){

    }
    public void SetProp(string prop){
        //Asigna el nombre de la variable y los valores de la misma
    }

    private void Awake()
    {
        inputField = GetComponentInChildren<TMP_InputField>();
        textComponent = GetComponentInChildren<TextMeshProUGUI>();
        
        if (inputField == null || textComponent == null)
        {
            Debug.LogError("CustomObject: Faltan componentes TMP_InputField o TextMeshProUGUI en los hijos.");
        }
        if (textComponent != null){
            SetText("texto");
        }
    }

    public void SetInputType(TMP_InputField.ContentType contentType)
    {
        inputField.contentType = contentType;
    }

    public void SetText(string newText)
    {
        currentTextValue = newText;
        textComponent.text = newText;
    }
}
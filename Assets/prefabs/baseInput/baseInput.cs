using UnityEngine;
using TMPro;
using Cards;
using Config;
using CardsGenerator;

public class BaseInput : MonoBehaviour
{
    TMP_InputField inputField;
    TextMeshProUGUI textComponent;
    public Field field;

    void Start()
    {
        //Asigna el nombre de la variable y los valores de la misma
        inputField = GetComponentInChildren<TMP_InputField>();
        textComponent = GetComponentInChildren<TextMeshProUGUI>();

        if (inputField == null || textComponent == null)
        {
            Debug.LogError("CustomObject: Faltan componentes TMP_InputField o TextMeshProUGUI en los hijos.");
        }
        SetText(field.fieldName);
    }

    private void Update()
    {
        
    }

    private void SetInputType(TMP_InputField.ContentType contentType)
    {
        inputField.contentType = contentType;
    }
    public void SetValue()
    {
        // El valor esta dado por el input
        Debug.Log(inputField.text.ToString());
        field.setValue(inputField.text.ToString());
    }

    private void SetText(string newText)
    {
        textComponent.text = newText;
        inputField.text = field.value.ToString();
    }

}
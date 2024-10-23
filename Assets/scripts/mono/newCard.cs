using System.Collections;
using System.Collections.Generic;
using Config;
using TMPro;
using UnityEngine;

public class newCard : MonoBehaviour
{
    public TMP_InputField inputField;
    public void CreateCard()
    {
        CardGeneration.CreateCard();
    }
    public void LoadImage()
    {

    }
    public void SetClassName()
    {
        CardGeneration.Card.setClassName(inputField.text.ToString());
    }
}

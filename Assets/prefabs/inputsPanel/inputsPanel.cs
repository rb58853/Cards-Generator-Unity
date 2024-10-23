using System.Collections;
using System.Collections.Generic;
using CardsGenerator;
using Config;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using Utils;

public class inputsPanel : MonoBehaviour
{
    public BaseInput inputPrefab; // Prefab del TMP_InputField
    public RectTransform parentPanel; // Panel padre donde se agregarán los campos de entrada
    public CardType typeCard;
    int i = 0;
    void Start()
    {
        DynamicGenerator card = CardGeneration.Cards[typeCard];

        foreach (Field field in card.Fields())
        {
            i++;
            AddInputField(field);
        }
    }
    void Update()
    {
        if (CardGeneration.CurrentTypeView == typeCard)
        {
            parentPanel.gameObject.SetActive(true);
        }
        else
        {
            parentPanel.gameObject.SetActive(false);
        }
    }

    void AddInputField(Field field)
    {
        GameObject newInput = Instantiate(inputPrefab.gameObject);
        newInput.GetComponent<BaseInput>().field = field;
        newInput.transform.SetParent(parentPanel, false);
        float parentHeight = parentPanel.GetComponent<RectTransform>().rect.height;
        newInput.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, parentHeight / 2 - 50 + (-inputPrefab.GetComponent<RectTransform>().rect.height - 5) * i); // Posiciona verticalmente
    }
}

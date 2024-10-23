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
    public int numberOfInputs = 5; // Número de campos de entrada a agregar
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

    void AddInputField(Field field)
    {
        BaseInput newInput = Instantiate(inputPrefab);
        newInput.field = field;
        newInput.transform.SetParent(parentPanel, false);
        newInput.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, (-inputPrefab.GetComponent<RectTransform>().rect.height - 5) * i); // Posiciona verticalmente
    }
}

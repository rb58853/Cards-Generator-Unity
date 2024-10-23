using System.Collections;
using System.Collections.Generic;
using CardsGenerator;
using Config;
using UnityEngine;

public class fullPanels : MonoBehaviour
{
    public inputsPanel panel; // Prefab de un panel
    public RectTransform parentPanel; // Panel padre donde se agregarán los campos de entrada
    void Start()
    {
        foreach (CardType type in CardGeneration.AvailableTypes)
        {
            AddPanel(type);
        }
    }

    void AddPanel(CardType type)
    {
        GameObject newPanel = Instantiate(panel.gameObject);
        newPanel.GetComponent<inputsPanel>().typeCard = type;
        newPanel.transform.SetParent(parentPanel, false);
        float parentHeight = parentPanel.GetComponent<RectTransform>().rect.height;

        newPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0); // Posiciona arriba
    }
}

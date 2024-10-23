using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using Config;
public class typesDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdownComponent;

    private void Start()
    {

    }
    private void Awake()
    {
        // dropdownComponent = GetComponentInChildren<TMP_Dropdown>();

        if (dropdownComponent == null)
        {
            Debug.LogError("CustomObject: Falta el dropdown component");
        }
        else
        {

            CardType[] options = CardGeneration.AvailableTypes;
            List<string> optionsStr = options.Select(item => item.ToString()).ToList();

            dropdownComponent.ClearOptions();
            dropdownComponent.AddOptions(optionsStr);
        }
    }
    public void OnDropdownValueChanged()
    {   
        
        Debug.Log("Opción seleccionada: " + dropdownComponent.value);
        CardGeneration.CurrentTypeView = (CardType)dropdownComponent.value;
        Debug.Log("El tipo cambio a: " + CardGeneration.CurrentTypeView.ToString());
    }
}

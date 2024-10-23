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

            string[] options = CardGeneration.AvailableTypes;

            dropdownComponent.ClearOptions();
            dropdownComponent.AddOptions(options.ToList());
        }
    }
}

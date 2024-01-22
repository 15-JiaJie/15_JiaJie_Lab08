using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public float SGDamount;
    public float Value;
    public InputField Amount;
    public InputField ValueText;
    public Toggle US_Dollars;
    public Toggle JP_Yen;
    public Text ErrorText;

    // Start is called before the first frame update
    void Start()
    {
        US_Dollars.isOn = false;
        JP_Yen.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Conversion()
    {
        
        if (Amount.text == null)
        {
            //ErrorText.GetComponent<Text>().text = "Key in a valid amount value";
            ValueText.text = "Key in a valid amount value";
        }

        if (Amount.text != null)
        {
            SGDamount = float.Parse(Amount.text);
        }

        if (US_Dollars.isOn && !JP_Yen.isOn)
        {
            Value = SGDamount * 0.74f;

            ValueText.text = Value.ToString() + "USD";
        }

        if (JP_Yen.isOn && !US_Dollars.isOn)
        {
            Value = SGDamount * 110.5f;
            ValueText.text = Value.ToString() + "JPY";
        }

        if ((US_Dollars.isOn) && (JP_Yen.isOn))
        {
            ValueText.text = "Choose only one option";
            //ValueText.GetComponent<Text>().color = Color.red;
        }
        
    }
    public void Clear()
    {
        ValueText.text = "";
        Amount.text = "";

        JP_Yen.GetComponent<Toggle>().isOn = false;
        US_Dollars.GetComponent<Toggle>().isOn = false;
    }

}

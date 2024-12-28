using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorManager : MonoBehaviour
{
    public TextMeshProUGUI resultLabel;
    public TMP_InputField firstInputField;
    public TMP_InputField secondInputField;
    public Button toplamaButton;
    public Button cikartmaButton;
    public Button bolmeButton;
    public Button carpmaButton;

    private int firstValue, secondValue;

    // Bu scriptin bulundugu obje spawn oldugunda veya objenin aktifligi acildiginda calisir. Calisma sirasi 2
    private void OnEnable()
    {
        toplamaButton.onClick.AddListener(Toplama);
        cikartmaButton.onClick.AddListener(Cikartma);
        bolmeButton.onClick.AddListener(Bolme);
        carpmaButton.onClick.AddListener(Carpma);
    }

    // Oyun veya obje kapatildigind calisan fonskyisondur.
    private void OnDisable()
    {
        toplamaButton.onClick.RemoveAllListeners();
        cikartmaButton.onClick.RemoveAllListeners();
        bolmeButton.onClick.RemoveAllListeners();
        carpmaButton.onClick.RemoveAllListeners();
    }

    private void Toplama()
    {
        TypeConvertor();
        int result = firstValue + secondValue;
        resultLabel.text = "Result = " + result;
    }

    private void Cikartma()
    {
        TypeConvertor();
        int result = firstValue - secondValue;
        resultLabel.text = "Result = " + result;
    }

    private void Bolme()
    {
        TypeConvertor();
        float result = firstValue / secondValue;
        resultLabel.text = "Result = " + result;
    }

    private void Carpma()
    {
        TypeConvertor();
        int result = firstValue * secondValue;
        resultLabel.text = "Result = " + result;
    }

    private void TypeConvertor()
    {
        string firstText = firstInputField.text;
        string secondText = secondInputField.text;

        firstValue = System.Convert.ToInt32(firstText);
        secondValue = System.Convert.ToInt32(secondText);
    }
}
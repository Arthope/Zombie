using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class Language : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern string GetLang();

    public static Language Instance;
    public string CurrentLanguage;
    [SerializeField] TextMeshProUGUI _languageText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            CurrentLanguage = GetLang();
            _languageText.text = CurrentLanguage;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

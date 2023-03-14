using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;
using Agava.YandexGames;
using Lean.Localization;

public class Language : MonoBehaviour
{
    
    public static Language Instance;
    public string CurrentLanguage;
    [SerializeField] TextMeshProUGUI _languageText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _languageText.text = CurrentLanguage;

            CurrentLanguage = YandexGamesSdk.Environment.i18n.lang;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

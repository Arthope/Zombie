using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InternacionaleText : MonoBehaviour
{
    [SerializeField] string _en;
    [SerializeField] string _ru;

    private void Start()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
        else if(Language.Instance.CurrentLanguage == "ru")
        {
            GetComponent<TextMeshProUGUI>().text = _ru;
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
    }
}

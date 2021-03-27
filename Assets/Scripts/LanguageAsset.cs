using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageAsset : MonoBehaviour {

    public Text text;

    public Language language;

    public enum Language
    {
        English,
        Spanish
    }

    public TextLanguage textLanguage;

    [System.Serializable]
    public struct TextLanguage
    {
        public string English;
        public string Spanish;
    }

    private void Start()
    {
        text.color = new Color(1, 1, 1, 0);
    }

}

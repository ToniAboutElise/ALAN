using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryText : MonoBehaviour
{
    public Animator animator;
    public Animation nextAnim;
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
        switch (language)
        {
            case Language.English:
                text.text = textLanguage.English;
                break;
            case Language.Spanish:
                text.text = textLanguage.Spanish;
                break;
        }
    }

    public void PlayTextSquence()
    {
        StartCoroutine(PlayTextSequenceCR());
    }

    protected IEnumerator PlayTextSequenceCR()
    {
        animator.SetTrigger("Enter");
        yield return new WaitForSeconds(4.2f);
        nextAnim.Play();
    }
}
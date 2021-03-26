using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Story/StoryText")]
public class StoryTextScriptableObject : ScriptableObject {

    public Animator animator;
    public Animation nextAnim;
    public Text text;

    public Language language;

    protected StoryTextScriptableObject storyTextScriptableObject;

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
        storyTextScriptableObject = this;
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
        CoroutinePlayer.coroutinePlayer.StartCoroutine(CoroutinePlayer.coroutinePlayer.PlayTextSequenceCR(animator, nextAnim));
    }

    public IEnumerator PlayTextSequenceCR()
    {
        animator.SetTrigger("Enter");
        yield return new WaitForSeconds(4.2f);
        nextAnim.Play();
    }

    public class CoroutinePlayer : MonoBehaviour
    {
        public static CoroutinePlayer coroutinePlayer;

        public void Start()
        {
            CoroutinePlayer.coroutinePlayer = this;
        }

        public IEnumerator PlayTextSequenceCR(Animator animator, Animation nextAnim)
        {
            animator.SetTrigger("Enter");
            yield return new WaitForSeconds(4.2f);
            nextAnim.Play();
        }
    }
}

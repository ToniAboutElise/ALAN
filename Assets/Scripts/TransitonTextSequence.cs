using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitonTextSequence : MonoBehaviour {

    public string nextScene;

	public List <LanguageAsset> languageAssetList;

    protected bool canPressContinue = false;

    private void Start()
    {
        StartCoroutine(TextAppear());
    }

    protected IEnumerator TextAppear()
    {
        yield return new WaitForSeconds(2);
        foreach(LanguageAsset la in languageAssetList)
        {
            la.GetComponent<Animation>().Play("textAppearTransitionScene");

            if(la != languageAssetList[languageAssetList.Count-1])
            yield return new WaitForSeconds(9);
        }
        canPressContinue = true;
    }

    protected IEnumerator TextDisappear()
    {
        yield return new WaitForSeconds(2);
        foreach (LanguageAsset la in languageAssetList)
        {
            la.GetComponent<Animation>().Play("textDisappearTransitionScene");
        }
        yield return new WaitForSeconds(2.4f);
        SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Single);
    }

    private void Update()
    {
        if(canPressContinue == true && (Input.GetMouseButton(0) || Input.GetButtonDown("Fire1")))
        {
            canPressContinue = false;
            StartCoroutine(TextDisappear());
        }
    }

}

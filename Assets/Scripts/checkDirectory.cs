using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class checkDirectory : MonoBehaviour
{

    public GameObject note;

    bool notePlayed, playingNote;

    public static string dir = Directory.GetCurrentDirectory();

    public GameObject buttonMess;

    public static string newDir;

    public void PlayNoteAnim()
    {
        if (notePlayed == false && playingNote == false)
        {
            note.GetComponent<Animation>().Play("in");
            notePlayed = true;
            StartCoroutine(playing());
        }
        else if (notePlayed == true && playingNote == false)
        {
            note.GetComponent<Animation>().Play("out");
            StartCoroutine(playing());
            notePlayed = false;
        }
    }

    IEnumerator playing()
    {
        playingNote = true;
        yield return new WaitForSeconds(1.2f);
        playingNote = false;
    }

    // Use this for initialization
    void Start()
    {
        notePlayed = false;
        playingNote = false;
        buttonMess.SetActive(false);
        //string gameName = Application.productName;
        Debug.Log(dir);
        //string value = Regex.Replace(dir, "[AronIsland]", "");
        //double parsedValue = double.Parse(value);
        for (int i = 0; i < dir.Length - 10; i++)
        {
            newDir += dir[i];
        }
        newDir += "About Elise";
        Debug.Log(newDir);
            if (Directory.Exists(newDir) && (Environment.OSVersion.Platform == PlatformID.Win32Windows || Environment.OSVersion.Platform == PlatformID.Win32S || Environment.OSVersion.Platform == PlatformID.Win32NT || Environment.OSVersion.Platform == PlatformID.WinCE || Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix))
        {
            buttonMess.SetActive(true);
            Debug.Log("Thanks for playing About Elise");
        }
    }
}

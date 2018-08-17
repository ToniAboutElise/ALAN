using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadZone : MonoBehaviour {

    public GameObject Respawn;
    public GameObject Player;

    IEnumerator Death()
    {
        Player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().LockPlayer();
        yield return new WaitForSeconds(1.2f);
        Player.transform.Rotate(0, -80, 0, Space.Self);
        Player.transform.position = Respawn.transform.position;
        yield return new WaitForSeconds(1.2f);
        Player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().UnlockPlayer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Player.transform.Rotate(0, -80, 0, Space.Self);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(Death());
        }
    }

}

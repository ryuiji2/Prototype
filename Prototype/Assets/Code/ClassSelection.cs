using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClassSelection : MonoBehaviour {

    public List<Image> selection = new List<Image> ();
    public List<GameObject> classes = new List<GameObject> ();
    public int curClass;
    public GameObject spawnLoc;
    public GameObject classSelect;


	void Start () {
        ClassShown ();
	}

    public void GoRight () {
        if (curClass < selection.Count-1) {
            curClass++;
            ClassShown ();
        }
    }

    public void GoLeft () {
        if (curClass > 0) {
            curClass--;
            ClassShown ();
        }
    }

    void ClassShown () {
        for (int i = 0; i < selection.Count; i++) {
            selection [i].gameObject.SetActive (false);
        }
        selection [curClass].gameObject.SetActive (true);
    }

    public void ConfirmClass () {
        //GetComponent<BasicClass> ().classSelected = curClass;
        Instantiate (classes [curClass], spawnLoc.transform.position, Quaternion.identity);
        classSelect.SetActive (false);
    }
}

using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    bool listUnrolled = false;
    public GameObject scroll;

	void Start ()
    {
        scroll.SetActive(true);
	}

	void Update ()
    {
        if (Input.GetKeyDown("space"))
            listUnrolled = !listUnrolled;
        scroll.SetActive(listUnrolled);
    }
}

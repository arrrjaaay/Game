using UnityEngine;
using System.Collections;

public class songcontrol : MonoBehaviour {

    public Transform Note1;
    public Transform Note2;
    public Transform Note3;

    public float songlength = 0;

    public KeyCode keyLeft;
    public KeyCode keyDown;
    public KeyCode keyRight;

    public static string destroyLeft = "n";
    public static string destroyDown = "n";
    public static string destroyRight = "n";
	
	// Update is called once per frame
	void FixedUpdate () {
        songlength += Time.deltaTime;

        if((songlength >= .1) && (songlength <= .125))
        {
            Instantiate(Note1, Note1.position, Note1.rotation);
        }
        if ((songlength >= 1) && (songlength <= 1.025))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 1.5) && (songlength <= 1.525))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(keyLeft) && (other.gameObject.name == "Note1(Clone)"))
        {
            destroyLeft = "y";
        }
        if (Input.GetKeyDown(keyDown) && (other.gameObject.name == "Note2(Clone)"))
        {
            destroyDown = "y";
        }
        if (Input.GetKeyDown(keyRight) && (other.gameObject.name == "Note3(Clone)"))
        {
            destroyRight = "y";
        }
    }
}

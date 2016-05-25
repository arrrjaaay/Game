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

        // Song notes go here.

        if((songlength >= .455) && (songlength <= .475))
        {
            Instantiate(Note1, Note1.position, Note1.rotation);
        }
        if ((songlength >= 1.1) && (songlength <= 1.125))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 1.3) && (songlength <= 1.325))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 1.7) && (songlength <= 1.725))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 1.9) && (songlength <= 1.925))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 2.1) && (songlength <= 2.125))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 2.4) && (songlength <= 2.425))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 3.4) && (songlength <= 3.425))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
            Instantiate(Note1, Note1.position, Note1.rotation);
        }

        if ((songlength >= 4.455) && (songlength <= 4.475))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 5.1) && (songlength <= 5.125))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 5.3) && (songlength <= 5.325))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 5.7) && (songlength <= 5.725))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 5.9) && (songlength <= 5.925))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 6.1) && (songlength <= 6.125))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
        }
        if ((songlength >= 6.4) && (songlength <= 6.425))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
            Instantiate(Note3, Note3.position, Note3.rotation);
        }
        if ((songlength >= 7.4) && (songlength <= 7.425))
        {
            Instantiate(Note2, Note2.position, Note2.rotation);
            Instantiate(Note1, Note1.position, Note1.rotation);
        }
        if ((songlength >= 7.8) && (songlength <= 7.825))
        {
            Instantiate(Note3, Note3.position, Note3.rotation);
            Instantiate(Note1, Note1.position, Note1.rotation);
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

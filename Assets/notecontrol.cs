using UnityEngine;
using System.Collections;

public class notecontrol : MonoBehaviour {

    public Transform burst;

	// Use this for initialization

	void Start () {
	    if (gameObject.name == "Note1(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5.75f, 0);
        }
        if (gameObject.name == "Note2(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5.75f, 0);
        }
        if (gameObject.name == "Note3(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5.75f, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if ((songcontrol.destroyLeft == "y") && (gameObject.name == "Note1(Clone)"))
        {
            Destroy(gameObject);
            Instantiate(burst,transform.position, burst.rotation);
        }
        if ((songcontrol.destroyDown == "y") && (gameObject.name == "Note2(Clone)"))
        {
            Destroy(gameObject);
            Instantiate(burst, transform.position, burst.rotation);
        }
        if ((songcontrol.destroyRight == "y") && (gameObject.name == "Note3(Clone)"))
        {
            Destroy(gameObject);
            Instantiate(burst, transform.position, burst.rotation);
        }
    }

    
    void OnTriggerExit2D()
    {
        GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
        Destroy(gameObject);
    }
}

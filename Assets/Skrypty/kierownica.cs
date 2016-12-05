using UnityEngine;
using System.Collections;

public class kierownica : MonoBehaviour
{
    public Vector3 kalibracjaPos = new Vector3(0, -100, 0);
    public float kalibracjaRot = 0.0f;
    GameObject target;
    GameObject kierunek;
    GameObject gaz;

	void Start ()
    {
        target = GameObject.Find("ImageTarget");
        kierunek = transform.FindChild("kierownica").gameObject;
        gaz = transform.FindChild("kwadrat").gameObject;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            kalibracjaPos = target.transform.position;
            kalibracjaRot = target.transform.rotation.eulerAngles.x;
        }
        //Debug.Log(target.transform.rotation.eulerAngles.y);
        if(target.transform.rotation.eulerAngles.y > 180)
        {
            kierunek.transform.rotation = Quaternion.Euler(0, 0, kalibracjaRot - target.transform.rotation.eulerAngles.x);
        }
        else
        {
            kierunek.transform.rotation = Quaternion.Euler(0, 0, kalibracjaRot - (180 -target.transform.rotation.eulerAngles.x));
        }
    }
}

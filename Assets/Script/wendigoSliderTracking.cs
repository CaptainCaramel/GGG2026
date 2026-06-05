using UnityEngine;

public class wendigoSliderTracking : MonoBehaviour
{
    public GameObject location, wendy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(location.transform.position.x, location.transform.position.y + 3);
        //transform.rotation = Quaternion.Euler(0,0, wendy.transform.eulerAngles.z + 90);
    }
}

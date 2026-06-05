using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class functionScript : MonoBehaviour
{
    //VICI ROM YLEOBA KODIA PRSOTA ZUSTAD 5:00 ARI DA IMENA MEZAREBA DAWERA

    public GameObject red, blue, yellow;
    public Animator roller;
    public Text Choose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rollOutYellow()
    {
        yellow.SetActive(true);
        red.SetActive(false); 
        blue.SetActive(false);
        rollout();
    }

    public void rollOutRed()
    {
        print("roll");
        red.SetActive(true);
        blue.SetActive(false);
        yellow.SetActive(false);
        rollout();
    }

    public void rollOutBlue()
    {
        blue.SetActive(true);
        yellow.SetActive(false);
        red.SetActive(false);
        rollout();
    }

    public void rollout()
    {
        roller.Play("rollout");
    }
}

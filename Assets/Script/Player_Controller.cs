using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    void Start()
    {
        Debug.Log("나 시작함");
    }

    void Update()
    {
        Debug.Log($"{Time.frameCount / 1000}s : Updated!!");
    }

    private void FixedUpdate()
    {
        
    }
}

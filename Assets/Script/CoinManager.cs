using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coin;
    public Transform[] positions;

    void Start()
    {
        if (positions.Length == 0)
            return;

        foreach (var trans in positions)
            Instantiate<GameObject>(coin, trans.position, trans.rotation);
    }
}
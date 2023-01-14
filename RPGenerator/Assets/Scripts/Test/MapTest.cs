using Assets.Scripts.Factories;
using UnityEngine;

public class MapTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Map map = MapFactory.CreateWithSize(5, 20);
        Debug.Log(map.InConsole());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

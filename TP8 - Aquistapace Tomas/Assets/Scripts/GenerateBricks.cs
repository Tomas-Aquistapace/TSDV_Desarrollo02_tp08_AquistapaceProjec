using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public int totalBricks = 0;

    public GameObject brick;

    private GameObject parent;

    void Start()
    {
        Generate();

        totalBricks = width * height;
        //GameManager.Get().player.GetComponent<PlayerStats>().bricksLeft = totalBricks;

        GameManager.Get().totalBricks = totalBricks;
    }

    void Generate() 
    {
        parent = new GameObject();
        parent.transform.position = Vector3.zero;
        parent.transform.name = "Bricks Parent";

        float cont = 0f;

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                GameObject go = brick;
                go.transform.position = new Vector3(x + 0.5f, y - cont, 0);

                Instantiate(go, parent.transform);
            }
            cont += 0.5f;
        }
    }
}

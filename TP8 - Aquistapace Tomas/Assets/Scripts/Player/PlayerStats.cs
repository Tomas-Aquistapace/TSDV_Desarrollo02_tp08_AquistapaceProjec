using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int lifes = 3;

    void Start()
    {
        GameManager.Get().score = 0;
    }

    public void Die()
    {
        lifes--;

        GameManager.Get().CheckEnd(lifes);

        if (lifes <= 0)
        {
            this.transform.GetComponent<MoveScene>().GoToScene();
        }
    }
}

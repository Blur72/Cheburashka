using UnityEngine;

public class BasketEater : MonoBehaviour
{
    private UIElements _UIElements;
    public HealthManager healthManager;

    private void Awake()
    {
        _UIElements = GameObject.Find("CanvasMainUI").GetComponent<UIElements>();
    }

    private void Update()
    {
        GameObject[] oranges = GameObject.FindGameObjectsWithTag("Orange");

        foreach (GameObject orange in oranges)
        {
            if (orange != null && orange.transform.position.y < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y)
            {
                Debug.Log("Апельсин пропущен!");
                healthManager.TakeDamage(); 
                Destroy(orange);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Orange"))
        {
            Debug.Log("Апельсин собран!");
            Destroy(other.gameObject); 
            _UIElements.CntPlusPlus();
        }
    }
}
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private bool DontDestroy = false;
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance=GameObject.FindObjectOfType<T>();
                if (instance==null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    instance=singleton.AddComponent<T>();
                }
            }
            return instance;
        }

    }
    public virtual void Awake()
    {
        if (instance==null)
        {
            instance = this as T;
            if (DontDestroy)
            {
                transform.parent = null;
                DontDestroyOnLoad(this.gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

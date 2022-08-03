using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private List<GameObject> _pools = new List<GameObject>();

    protected void Initialize(GameObject prefab)
    {
        GameObject spawned = Instantiate(prefab, _container.transform);
        spawned.SetActive(false);

        _pools.Add(spawned);

    }
    protected bool TryGetObject(out GameObject result)
    {
        result = _pools.First(p => p.activeSelf == false);
        return result != null;
    }
}

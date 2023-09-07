using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    [SerializeField]
    private bool walkable;

    [SerializeField]
    private bool cover;

    protected Coords coords;

    protected void Start()
    {
        GridController.instance.AddObstacle(this);

        coords = GridController.instance.DetermineCoords(transform);
    }

    public void Swap(Coords newCoords)
    {
        GridController.instance.RemoveObstacle(this);

        transform.position = GridController.instance.GetPositionOfCoord(newCoords);
        coords = newCoords;

        GridController.instance.AddObstacle(this);
    }

    public bool IsWalkable()
    {
        return walkable;
    }

    public bool IsCover()
    {
        return cover;
    }

    public Coords GetCoords()
    {
        return coords;
    }
}

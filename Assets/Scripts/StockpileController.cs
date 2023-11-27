using UnityEngine;

public class StockpileController : MonoBehaviour
{
    WorldMapState state;
    public GameObject stockpilePrefab;

    public void AddSquare(SquareState squareState, StockpileState stockpileState) {
        GameObject stockpileSquareGameObject = Instantiate(stockpilePrefab, new Vector3(squareState.x, squareState.y, squareState.z), Quaternion.identity);
        stockpileSquareGameObject.transform.SetParent(gameObject.transform);
        stockpileSquareGameObject.transform.position = new Vector3(squareState.x, squareState.y, squareState.z);
        StockpileSquare stockpileSquareComponent = stockpileSquareGameObject.GetComponent<StockpileSquare>();
        stockpileSquareComponent.stockpileUUID = stockpileState.uuid;
        stockpileSquareComponent.SetStockpileSquareState(squareState);
    }

    public void AssignRoomState(WorldMapState state) {
        this.state = state;
        this.state.stockpiles.OnAdd( (uuid, stockpile) => {
            Debug.Log("New stockpile with uuid " + uuid);
            stockpile.assignedSquares.ForEach( (SquareState squareState) => {
                this.AddSquare(squareState, stockpile);
            });
        });
    }
}

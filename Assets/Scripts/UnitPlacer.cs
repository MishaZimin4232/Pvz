using UnityEngine;

public class UnitPlacer2D : MonoBehaviour 
{
    public GameGrid Grid;
    public Camera GameCamera; 
    private Unit selectedUnit;
    
    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) {
            HandlePlacement();
        }
        
        
        UpdatePlacementPreview();
    }
    
    public void SelectUnit(Unit unitPrefab)
    {
        selectedUnit = unitPrefab;
    }
    
    private void HandlePlacement() {
        if (selectedUnit ==null) return;
        
        Cell targetCell = GetCellUnderMouse();
        if (targetCell == null) return;
        
       
        
        PlaceUnit(selectedUnit, targetCell);
    }
    private void PlaceUnit(Unit unit, Cell cell)
    {
        Unit newUnit = Instantiate(unit, cell.Position, Quaternion.identity);
       
        cell.CurrentUnit = newUnit;
        newUnit.AssignToCell(cell);
        
        
        selectedUnit = null;
    }
    private Cell GetCellUnderMouse()
    {
        Vector2 mouseWorldPos = GameCamera.ScreenToWorldPoint(Input.mousePosition);
        return Grid.GetCell(mouseWorldPos);
    }
    
    
    
    private void UpdatePlacementPreview()
    {
        if (selectedUnit == null) return;
        
        Cell cellUnderMouse = GetCellUnderMouse();
        
    }
}


        namespace Exomine2JSWSAFAPI.Models.DTOs;

public class ColonyMineralDTO
{
    public int Id {get; set;}
    public int ColonyId {get; set;}
    public int MineralId {get; set;}
    public int Quantity {get; set;}
    public Colony Colony {get; set;}
    public Mineral Mineral {get; set;}
}
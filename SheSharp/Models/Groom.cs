namespace SheSharp.Models
{

 public class Groom
 {
  public int Id { get; set; }
  public string Name { get; set; }
  public string StartTime { get; set; }
  public string EndTime { get; set; }
  public string groomLocation { get; set; }
  public int Size { get; set; }
  public string Breed {get; set;}
   public float Price { get; set; }
   public string Services { get; set; }
   public float Tip { get; set; }
   public string CreatorId { get; set; }
   public Profile Creator { get; set; }
 }
}
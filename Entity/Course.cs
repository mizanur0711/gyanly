namespace Entity;

public class Course :  BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Instructor { get; set; }
    public decimal Rating { get; set; }
    public string Image { get; set; }
    public string SubTitle { get; set; } 
    public int Students { get; set; }
    
}
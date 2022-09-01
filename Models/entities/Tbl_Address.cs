using System.ComponentModel.DataAnnotations;

public class Tbl_Address
{
    [Key]
    public int id { get; set; }
    public double lat { get; set; }
public double longt { get; set; }
public double address { get; set; }

}
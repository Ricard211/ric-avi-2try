namespace ric_avi_iskfu19.Models;


public class Helmet{

    public Helmet(Helmetmaker helmetmaker){
        
        //will
        /*Id = Guid.NewGuid();
        Maker = helmetMake.Maker;
        Name = helmetMake.Name;
        ProductionYear = helmetMake.ProductionYear;
        Price = helmetMake.Price;*/

    }

public int helmetid {get; set;}
public string? helmetmaker {get; set;}
public string? helmetname {get; set;}
public DateTime helmetproductionyear {get; set;}
public int helmetprice {get; set;}

}
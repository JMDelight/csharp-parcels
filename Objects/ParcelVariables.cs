namespace Parcels.Objects
{
  public class ParcelVariables
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public string Height {get; set;}
    public string Weight {get; set;}

    public string Volume(string Length, string Width, string Height)
    {
      int intLength = int.Parse(Length);
      int intWidth = int.Parse(Width);
      int intHeight = int.Parse(Height);
      string result = "10";
      return result;
    }

    public int Price(int Volume, string Weight)
    {
      int intWeight = int.Parse(Weight);
      int result = 15;
      return result;
    }
  }
}

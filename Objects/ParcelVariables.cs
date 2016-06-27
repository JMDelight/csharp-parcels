namespace Parcels.Objects
{
  public class ParcelVariables
  {
    public string Length {get; set;}
    public string Width {get; set;}
    public string Height {get; set;}
    public string Weight {get; set;}

    public int Volume()
    {
      int intLength = int.Parse(Length);
      int intWidth = int.Parse(Width);
      int intHeight = int.Parse(Height);
      int result = intHeight * intWidth * intLength;
      return result;
    }

    public int Price()
    {
      int intWeight = int.Parse(Weight);
      int result = intWeight * Volume();
      return result;
    }
  }
}

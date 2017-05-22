namespace Triangles.Objects {
  public class TriangleVariables
  {
    private int _side1;
    private int _side2;
    private int _side3;
    private string _result;

    public int GetSideOne()
    {
      return _side1;
    }
    public void SetSideOne(int side1)
    {
      _side1 = side1;
    }
    public int GetSideTwo()
    {
      return _side2;
    }
    public void SetSideTwo(int side2)
    {
      _side2 = side2;
    }
    public int GetSideThree()
    {
      return _side3;
    }
    public void SetSideThree(int side3)
    {
      _side3 = side3;
    }
    public string GetResult()
    {
      return _result;
    }
    public void SetResult(string result)
    {
      _result = result;
    }

    public string CheckType(int side1, int side2, int side3)
    {
      if ((side2+side3 <= side1) || (side1+side2 <= side3) || (side1+side3 <= side2)) {
        return _result = "Not a triangle";
      }
      else if (side1==side2&&side2==side3&&side1==side3) {
        return _result = "Equilateral";
      }
      else if (side1==side2||side2==side3||side1==side3) {
        return _result = "Isosceles";
      }
      else {
        return _result = "Scalene";
      }
    }
  }
}

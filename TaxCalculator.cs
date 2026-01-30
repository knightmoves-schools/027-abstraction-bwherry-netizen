namespace knightmoves;
public class TaxCalculator
{
    private int _Rate = 15;
    public string State = "TX";
    public bool Exempt = false;
    
    public int Calculate(){
        if(Exempt){
            return _CalculateExempt(1.37);
        }else{
            return _CalculateNonExempt(5.72);
        }
    }

    private int _CalculateNonExempt(double v)
    {
        return 0;
    }

    private int _CalculateExempt(double v)
    {
        return 0;
    }
}




class RemoteControlCar
{
    private int _distanceDriven;
    private int _betteryPercentage;
    public  RemoteControlCar()
    {
        _distanceDriven=0;
        _betteryPercentage=100;
    }
    public static RemoteControlCar Buy()=>new RemoteControlCar();
   
    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        
      return _betteryPercentage==0 ? $"Battery empty" : $"Battery at {_betteryPercentage}%";
    }

    public void Drive()
    {
        if(_betteryPercentage==0)
        return;
        _distanceDriven+=20;
        _betteryPercentage-=1;
        
    }
}

using System;

public class Location
{
    // 1. get current location.
    // 2. plot a route on a map
    // 3. track current location
    private double longitude;
    private double lattitude;
    public double Longitude { get => longitude; set => longitude = value; }
    public double Lattitude { get => lattitude; set => lattitude = value; }
    public Location(double longitude,double lattitude)
	{
        this.longitude = longitude;
        this.lattitude = lattitude;
	}

    
}

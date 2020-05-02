using System;
using System.Collections.Generic;


class studentas 
{
  public string v {get; set;}
  public string p {get; set;}
  public double e {get; set;}
  public double vidurkis {get; set;}
  public double mediana {get; set;}

  public List<double> nd = new List<double>();
  public double vid {get; set;} = 0;

  public studentas (string v, string p, double e, List<double> nd)
  {
    this.v = v;
    this.p = p;
    this.e = e;
    this.nd = nd;
    foreach (var value in this.nd)
    {
      this.vid = this.vid + value;
    }
    this.vid = this.vid / this.nd.Count;
    this.vidurkis = this.vid * 0.3 + this.e * 0.7;
    
    this.nd.Sort();
    this.mediana = this.nd[this.nd.Count / 2] * 0.3 + this.e * 0.7;
  }
}
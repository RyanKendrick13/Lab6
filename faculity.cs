using System;


class Faculity:Person {
  public string Id{get;set;}
  public string Title{get;set;}
  public DateTime DateofEmployment{get;set;}
  public string Employer{get;set;}
  public double YearlySalary{get;set;}
  public bool Tenured{get;set;}
  DateTime YearsofExperince;


  Faculity(){
    Title = "Instructor";
  }
  Faculity(string Firstname, string Lastname){
    Title = "Instructor";

  }

  public bool GrantTenure(){

   int YearsofExperince= Convert.ToInt32(DateTime.Today-DateofEmployment);
   if(YearsofExperince>=5){
     Tenured=true;
     return Tenured;
   }
   else{
     
      return Tenured= false;
   }
  
  



  }
  public void Promote(){
    int YearsofExperince= Convert.ToInt32(DateTime.Today-DateofEmployment);
    if((Title=="Instructor")&&(YearsofExperince>2)){
      Title= "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
    }
    else if((Title=="Assistant Professor")&&(YearsofExperince>5)){
      Title="Assistant Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");

    }
    else if ((Title=="Associate Professor")&&(YearsofExperince>10)){
      Title="Professor";
      Console.WriteLine("Faculty promoted to Professor rank");

    }
    else if (Title=="Professor"){
     Console.WriteLine("No more promotion possible");
    }
  
     
  }
 
 public override void Intro() {
     base.Intro();
   Console.WriteLine("I work as a " + Title+ " "+" at "+ Employer+ " since"+ DateofEmployment);

 } 
 

  

}



  



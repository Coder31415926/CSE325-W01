

string name = "Chris";
string location = "Virginia";
Console.WriteLine($"My name is {name}");
Console.WriteLine($"I am from {location}");
Console.WriteLine(DateTime.Today.ToShortDateString());
DateTime christmas = new DateTime(DateTime.Today.Year,12,25);
Console.WriteLine("There are "+ (christmas - DateTime.Today) + " days until Christmas");

double width, height, woodLength, glassArea; 
string widthString, heightString; 
Console.WriteLine("What is the width: ");
widthString = Console.ReadLine(); 
width = double.Parse(widthString); 
Console.WriteLine("What is the height: ");
heightString = Console.ReadLine(); 
height = double.Parse(heightString); 
woodLength = 2 * ( width + height ) * 3.25 ; 
glassArea = 2 * ( width * height ) ; 
Console.WriteLine ( "The length of the wood is " +  
woodLength + " feet" ) ; 
Console.WriteLine( "The area of the glass is " +  
glassArea + " square metres" ) ;
Console.ReadKey();

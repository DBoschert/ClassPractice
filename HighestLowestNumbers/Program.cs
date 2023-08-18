using HighestLowestNumbers;

Student.Print("This is a static method display");

var david = new Student("David", "OH");
Console.WriteLine($"Id [{david.Id}], Name is [{david.Name}] State is [{david.State}]");

var megan = new Student("Megan");

var tony = new Student();
tony.Name = "Tony";
tony.State = "AZ";
tony.ChangeName("Anthony");

Console.WriteLine($"Students are {megan.Name} and {tony.Name}");


Console.WriteLine($"Id [{megan.Id}]Name is [{megan.Name}] State is [{megan.State}]");
Console.WriteLine($"Id [{tony.Id}]Name is [{tony.Name}] State is [{tony.State}]");




/*

int[] nbrs = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};




// FIZZBUZZ QUESTION
for(int i = 1; i <= 30; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZBUZZ");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("FIZZ");
    }
    else if(i % 5 == 0) 
    {
        Console.WriteLine("BUZZ");
    }
    else
    {
        Console.WriteLine($"The number is {i}");
    }
}




//Switch Expression
var stateCode = "OH";
var stateName = "";

stateName = stateCode switch
{
    "OH" => "Ohio",
    "KY" => "Kentucky",
    "IN" => "Indiana",
    _ => "I don't know"
};





var stateCode = "OH";
var stateName = "";

//Switch Statement
switch (stateCode){
    case "OH":
        stateName = "Ohio";
        break;
    case "KY":
        stateName = "Kentucky";
        break;
    case "IN":
        stateName = "Indiana";
        break;
    default:
        stateName = "I don't know";
        break;
}




var stateCode = "OH";
var stateName = "";



if (stateCode == "OH")
{
    stateName = "OH";
}
else if (stateCode == "KY")
{
    stateName = "Kentucky";
}
else if (stateCode == "IN")
{
    stateName = "Indiana";
}
else
{
    stateName = "I don't Know";
}

//Get the highest and lowest of all the numbers in nbrs
int highest = 0;
int lowest = 1000;


foreach (int number in nbrs)
{
    if(highest < number)
    {
        highest = number;
    }
    if (lowest > number) {
        lowest = number;
    }
}
Console.WriteLine("The Lowest and Highest numbers in the nbrs array: ");
Console.WriteLine($"Lowest number is: {lowest}");
Console.WriteLine($"Highest number is: {highest}");


//Average of all the numbers in nbrs
int sum = 0;
int count = 0;
foreach (int number in nbrs)
{
    sum += number;
    count++;
}
Console.WriteLine($"The average is: {(double)sum / count}");


//Prints all the odd numbers from 1-25 cubed
int num = 0;

while(num <= 25)
{
    if(num % 2 == 1)
    {
        Console.WriteLine($"The number {num} cubed is {num*num*num}");
    }
    num++;
}

*/

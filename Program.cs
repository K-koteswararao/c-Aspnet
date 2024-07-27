using Student2;
var a = new Std();
Console.WriteLine("Enter the percentage");
var percentage = Convert.ToInt32(Console.ReadLine());
var grade = a.GetGradeByPercentage(percentage);
Console.WriteLine(grade);
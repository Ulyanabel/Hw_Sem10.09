// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
double A;
double B;
double C;
A = Convert.ToDouble(Console.ReadLine());
B = Convert.ToDouble(Console.ReadLine());
C = Math.Pow(A, B);
Console.WriteLine(""+A+" , "+B+" = "+C+"");
Console.ReadLine();

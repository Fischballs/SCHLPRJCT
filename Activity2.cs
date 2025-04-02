class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("grading sa studintz \n");
        int[] student1 = { 87, 76, 89 }; int[] student2 = { 90, 89, 99 }; int[] student3 = { 100, 98, 98 }; int[] student4 = { 89, 98, 87 }; int[] student5 = { 88, 89, 90 };
       
       Console.Write("student 1: ");
        foreach (int grade in student1)
        {
            Console.Write(grade + " ");
        }
        Console.Write("\n");

        Console.Write("student 2: ");
        foreach (int grade in student2)
        {
            Console.Write(grade + " ");
        }
        Console.Write("\n");

        Console.Write("student 3: ");
        foreach (int grade in student3)
        {
            Console.Write(grade + " ");
        }
        Console.Write("\n");

        Console.Write("student 4: ");
        foreach (int grade in student4)
        {
            Console.Write(grade + " ");
        }
        Console.Write("\n");

        Console.Write("student 5: ");
        foreach (int grade in student5)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Student average:\n");

        double Studentaverage1 = Math.Round(student1.Average(), 2); Console.WriteLine("student 1: " + Studentaverage1);
        double Studentaverage2 = Math.Round(student2.Average(), 2); Console.WriteLine("student 2: " + Studentaverage2);
        double Studentaverage3 = Math.Round(student3.Average(), 2); Console.WriteLine("student 3: " + Studentaverage3);
        double Studentaverage4 = Math.Round(student4.Average(), 2); Console.WriteLine("student 4: " + Studentaverage4);
        double Studentaverage5 = Math.Round(student5.Average(), 2); Console.WriteLine("student 5: " + Studentaverage5 + "\n");

        Console.WriteLine("highest grades for every student");

        int Hiscore1 = student1.Max(); Console.WriteLine("student 1: " + Hiscore1);
        int Hiscore2 = student2.Max(); Console.WriteLine("student 2: " + Hiscore2);
        int Hiscore3 = student3.Max(); Console.WriteLine("student 3: " + Hiscore3);
        int Hiscore4 = student4.Max(); Console.WriteLine("student 4: " + Hiscore4);
        int Hiscore5 = student5.Max(); Console.WriteLine("student 5: " + Hiscore5 +"\n");

        Console.WriteLine("Lowest scores\n");

        int Low1 = student1.Min(); Console.WriteLine("Student 1: " + Low1);
        int Low2 = student2.Min(); Console.WriteLine("Student 2: " + Low2);
        int Low3 = student3.Min(); Console.WriteLine("Student 3: " + Low3);
        int Low4 = student4.Min(); Console.WriteLine("Student 4: " + Low4);
        int Low5 = student5.Min(); Console.WriteLine("Student 5: " + Low5 + "\n");

        Console.WriteLine("median of students\n");

        Array.Sort(student1); Console.WriteLine("Student 1: " + student1[1]);
        Array.Sort(student2); Console.WriteLine("Student 2: " + student2[1]);
        Array.Sort(student3); Console.WriteLine("Student 3: " + student3[1]);
        Array.Sort(student4); Console.WriteLine("Student 4: " + student4[1]);
        Array.Sort(student5); Console.WriteLine("Student 5: " + student5[1]);

    }
}

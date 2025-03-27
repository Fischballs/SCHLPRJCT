class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("grading sa studintz \n");
        int[] student1 = { 87, 76, 89 };
        int[] student2 = { 90, 89, 99 };
        int[] student3 = { 100, 98, 98 };
        int[] student4 = { 89, 98, 87 };
        int[] student5 = { 88, 89, 90 };

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

        double Studentaverage1 = Math.Round(student1.Average(), 2);
        double Studentaverage2 = Math.Round(student2.Average(), 2);
        double Studentaverage3 = Math.Round(student3.Average(), 2);
        double Studentaverage4 = Math.Round(student4.Average(), 2);
        double Studentaverage5 = Math.Round(student5.Average(), 2);

        Console.WriteLine("student 1: " + Studentaverage1);
        Console.WriteLine("student 2: " + Studentaverage2);
        Console.WriteLine("student 3: " + Studentaverage3);
        Console.WriteLine("student 4: " + Studentaverage4);
        Console.WriteLine("student 5: " + Studentaverage5 + "\n");

        Console.WriteLine("highest grades for every student");

        int Hiscore1 = student1.Max();
        int Hiscore2 = student2.Max();
        int Hiscore3 = student3.Max();
        int Hiscore4 = student4.Max();
        int Hiscore5 = student5.Max();

        Console.WriteLine("student 1: "+ Hiscore1);
        Console.WriteLine("student 2: "+ Hiscore2);
        Console.WriteLine("student 3: "+ Hiscore3);
        Console.WriteLine("student 4: "+ Hiscore4);
        Console.WriteLine("student 5: "+ Hiscore5);
    }
}

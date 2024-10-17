class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentDbContext())
        {
            var student = new Student { Name = "shagun" };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }
    }
}

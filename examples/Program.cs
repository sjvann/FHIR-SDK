using Examples;

namespace R4PatientDemo
{
    /// <summary>
    /// R4 Patient �ܽd�{��
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                R4PatientExample.RunExample();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"���~: {ex.Message}");
                Console.WriteLine($"���|�l��: {ex.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine("�����N��h�X...");
            Console.ReadKey();
        }
    }
}
using Examples;

namespace R4PatientDemo
{
    /// <summary>
    /// R4 Patient 示範程式
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
                Console.WriteLine($"錯誤: {ex.Message}");
                Console.WriteLine($"堆疊追蹤: {ex.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine("按任意鍵退出...");
            Console.ReadKey();
        }
    }
}
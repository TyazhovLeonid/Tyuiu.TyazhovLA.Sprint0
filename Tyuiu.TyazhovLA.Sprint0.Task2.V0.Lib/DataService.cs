using System.Net.NetworkInformation;

namespace Tyuiu.TyazhovLA.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет, {name}";
        }
    }
}

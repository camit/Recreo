using FileHelpers;

namespace ImportProcess
{
    public class Parser<T>
    {
        /// <summary>
        /// Generic Function to parse the csv file of generic type
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <returns>Generic Result Set of Type T</returns>
        public static T[] ParseToList(string inputFilePath)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(T));
            T[] result = engine.ReadFile(inputFilePath) as T[];
            return result;

        }

    }
}

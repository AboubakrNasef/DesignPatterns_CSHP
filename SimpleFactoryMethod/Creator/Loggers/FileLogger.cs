namespace SimpleFactoryMethod.Creator.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("logging to file");
            using (var fileStream = File.Open("logfile.txt", FileMode.Append, FileAccess.Write))
            {
                byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message + Environment.NewLine);
                fileStream.Write(messageBytes, 0, messageBytes.Length);
            }
        }
    }
}

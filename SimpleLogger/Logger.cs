using System.Text;

namespace SimpleLogger
{
    public class Logger : ILogger
    {
        private string _logFile = string.Empty;

        public Logger(string fname)
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            _logFile = Path.Combine(basePath, fname);
            System.Diagnostics.Debug.WriteLine($"Logger created: {_logFile}");
        }

        public void Write(string msg)
        {
            try
            {
                using (var sw = new StreamWriter(_logFile, true, Encoding.Default))
                {
                    sw.Write(DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss - "));
                    sw.WriteLine(msg);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Logger Exception {_logFile}: {ex.Message}");
            }
        }



    }
}

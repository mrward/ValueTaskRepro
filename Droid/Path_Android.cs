using System;
using System.Threading.Tasks;

namespace ValueTaskRepro.Droid
{
    public class Path_Android : IPath
    {
        string _path;

        public ValueTask<string> GetPath()
        {
            if (string.IsNullOrWhiteSpace(_path))
                return new ValueTask<string>(_path);

            return new ValueTask<string>(GetPathTask());         
        }

        async Task<string> GetPathTask()
        {
            _path = await Task.Run(() => Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            return _path;
        }
    }
}

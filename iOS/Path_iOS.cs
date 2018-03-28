using System;
using System.Threading.Tasks;

namespace ValueTaskRepro.iOS
{
	public class Path_iOS : IPath
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

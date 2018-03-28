using System.Threading.Tasks;

using Xamarin.Forms;

namespace ValueTaskRepro
{
	public class App : Application
	{
		public App() => MainPage = new ContentPage();
	}

    public interface IPath
	{
		ValueTask<string> GetPath();
	}
}

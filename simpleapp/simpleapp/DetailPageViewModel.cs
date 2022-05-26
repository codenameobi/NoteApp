using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace simpleapp
{
	public class DetailPageViewModel : INotifyPropertyChanged
	{

        public DetailPageViewModel(string note)
		{
			DismissPageCommand = new Command(async () =>
			{
				await Application.Current.MainPage.Navigation.PopAsync();

				//modal navigation
				//await Application.Current.MainPage.Navigation.PopModalAsync();
			});

			NoteText = note;
		}

        public event PropertyChangedEventHandler PropertyChanged;

		string noteText;

		public string NoteText
		{
			get => noteText;

			set
			{
				noteText = value;

				var args = new PropertyChangedEventArgs(nameof(NoteText));

				PropertyChanged?.Invoke(this, args);
			}
		}

		public Command DismissPageCommand { get; }
	}
}

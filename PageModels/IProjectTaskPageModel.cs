using CommunityToolkit.Mvvm.Input;
using Demo.Models;

namespace Demo.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}
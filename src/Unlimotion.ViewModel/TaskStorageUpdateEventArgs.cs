using System;
using Unlimotion.ViewModel.Models;

namespace Unlimotion.ViewModel;

public class TaskStorageUpdateEventArgs : EventArgs
{
    public string Id { get; set; }
    public UpdateType Type { get; set; }
}
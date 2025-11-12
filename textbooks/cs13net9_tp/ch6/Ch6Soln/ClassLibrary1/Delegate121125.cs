
namespace TP.SharedLibraries;

public delegate void TPEventHandler(object? sender, EventArgs e);
public delegate void TPEventHandler<TEventArgs>(object? sender, TEventArgs e);